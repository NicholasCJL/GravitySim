using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleGrav {
   public partial class Canvas : Form {
      public Double xmin, ymin, xmax, ymax;
      private Double vx0, vy0, m0;
      private SolidBrush[] Palette = new SolidBrush[64];
      private Pen[] Ink = new Pen[64];
      private Random rng = new Random();
      private bool started = false;
      private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
      private Stopwatch FPS;
      private TimeSpan elapsed;

      public Canvas() {
         InitializeComponent();
         m0 = 0;
         timestep.Text = Convert.ToString(MainFile.dt);
         xmin = 100 * (ClientRectangle.Left);
         xmax = 100 * (ClientRectangle.Right - sidebar.Width);
         ymin = 100 * (ClientRectangle.Top);
         ymax = 100 * (ClientRectangle.Bottom);
         for (Int32 i = 0; i < 4; i++) {
            for (Int32 j = 0; j < 4; j++) {
               for (Int32 k = 0; k < 4; k++) {
                  Palette[16 * i + 4 * j + k] = new SolidBrush(Color.FromArgb(255, 85 * i, 85 * j, 85 * k));
                  Ink[16 * i + 4 * j + k] = new Pen(Color.FromArgb(255, 85 * i, 85 * j, 85 * k));
               }
            }
         }
      }
      
      public void Simulate() {
         timer.Interval = 1;
         timer.Tick += new EventHandler(tick);
         started = true;
         FPS = Stopwatch.StartNew();
         timer.Start();
      }

      private void tick(object sender, EventArgs e) {
         timer.Stop();
         FPS.Stop();
         elapsed = FPS.Elapsed;
         FPSCounter.Text = Convert.ToString(Math.Round(1000.0 / elapsed.TotalMilliseconds, 2));
         MainFile.NextStep();
         ObjCounter.Text = Convert.ToString(MainFile.Calculator.bodies.Count);
         Refresh();
         FPS = Stopwatch.StartNew();
         timer.Start();
      }

      private void Canvas_Resize(object sender, EventArgs e) {
         xmin = 100 * (ClientRectangle.Left);
         xmax = 100 * (ClientRectangle.Right - sidebar.Width);
         ymin = 100 * (ClientRectangle.Top);
         ymax = 100 * (ClientRectangle.Bottom);
      }

      private void Reset_Click(object sender, EventArgs e) {
         timer.Stop();
         MainFile.Reset();
         started = false;
         ObjCounter.Text = Convert.ToString(MainFile.Calculator.bodies.Count);
         Refresh();
      }

      private void Start_Click(object sender, EventArgs e) {
         if(IntMethod.SelectedIndex == -1) {
            MessageBox.Show("Please select integration method.");
            return;
         }
         if(SimMethod.SelectedIndex == -1) {
            MessageBox.Show("Please select simulation method.");
            return;
         }
         MainFile.StartSim((IntMethod.SelectedIndex == 0 ? true : false), (SimMethod.SelectedIndex == 0 ? false : true));
      }

      protected override void OnPaint(PaintEventArgs e) {
         base.OnPaint(e);
         e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
         if (!started) {
            for(Int32 i=0; i<MainFile.preloadbodies.Count; i++) {
               e.Graphics.FillEllipse(Palette[MainFile.preloadbodies[i].color], Convert.ToSingle(MainFile.preloadbodies[i].x - MainFile.preloadbodies[i].d / 2) / 100, Convert.ToSingle(MainFile.preloadbodies[i].y - MainFile.preloadbodies[i].d / 2) / 100, Convert.ToSingle(MainFile.preloadbodies[i].d/100), Convert.ToSingle(MainFile.preloadbodies[i].d/100));
            }
         }
         else {
            for(Int32 i=0; i<MainFile.Calculator.bodies.Count; i++) {
               e.Graphics.FillEllipse(Palette[MainFile.Calculator.bodies[i].color], Convert.ToSingle(MainFile.Calculator.bodies[i].x - MainFile.Calculator.bodies[i].d / 2) / 100, Convert.ToSingle(MainFile.Calculator.bodies[i].y - MainFile.Calculator.bodies[i].d / 2) / 100, Convert.ToSingle(MainFile.Calculator.bodies[i].d / 100), Convert.ToSingle(MainFile.Calculator.bodies[i].d / 100));
               System.Drawing.Drawing2D.GraphicsPath trail = new System.Drawing.Drawing2D.GraphicsPath();
               trail.AddCurve(MainFile.Calculator.bodies[i].trail.ToArray());
               e.Graphics.DrawPath(Ink[MainFile.Calculator.bodies[i].color], trail);
            }
         }
      }

      private void Canvas_MouseClick(object sender, MouseEventArgs e) {
         if (e.Button == MouseButtons.Left) {
            if (!started) {
               if (!(m0 == 0)) {
                  var relPoint = PointToClient(Cursor.Position);
                  MainFile.AddBody(relPoint.X * 100, relPoint.Y * 100, vx0, vy0, m0, rng.Next(1, 64));
                  ObjCounter.Text = Convert.ToString(MainFile.preloadbodies.Count);
                  Refresh();
               }
            }
            else {
               var relPoint = PointToClient(Cursor.Position);
               MainFile.Calculator.AddBody(new Body(relPoint.X * 100, relPoint.Y * 100, vx0, vy0, m0, rng.Next(1, 64)));
            }
         }
      }

      private void UpdateInput_Click(object sender, EventArgs e) {
         Double vx, vy, m;
         if((Double.TryParse(this.vel_x.Text, out vx))&(Double.TryParse(this.vel_y.Text, out vy))&(Double.TryParse(this.mass.Text, out m))) {
            vx0 = vx; vy0 = vy; m0 = m;
            vel_x.Text = "";
            vel_y.Text = "";
            mass.Text = "";
         }
      }   
   }
}
