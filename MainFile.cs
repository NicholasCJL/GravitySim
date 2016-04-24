using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGrav {
   static class MainFile {
      public static Double dt = 1.0;
      public static Canvas canvas;
      public static List<Body> preloadbodies = new List<Body>();
      public static ICalculator Calculator;
      static void Main() {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         canvas = new Canvas();
         Application.Run(canvas);
      }

      public static void AddBody(Double x0, Double y0, Double vx0, Double vy0, Double m0, Int32 c, Double d0 = 500) {
         preloadbodies.Add(new Body(x0, y0, vx0, vy0, m0, c, d0));
      }

      public static void StartSim(bool Euler, bool BH) {
         Calculator = new SimpleCalculator();
         foreach(Body body in preloadbodies) {
            Calculator.AddBody(body);
         }
         Calculator.InitParams(dt);
         canvas.Simulate();
      }

      public static void NextStep() {
         Calculator.UpdatePositions(dt);
      }

      public static void Reset() {
         preloadbodies.Clear();
         Calculator.Reset();
      }
   }

   //object parameters class
   public class Body {
      public Double x, y, vx, vy, m; //essential parameters
      public Double ax, ay; //acceleration used for updating object states
      public Double d; //diameter
      public Int32 color; //color
      public Queue<PointF> trail = new Queue<PointF>();
      public Body(Double x0, Double y0, Double vx0, Double vy0, Double m0, Int32 c, Double d0 = 500) {
         x = x0; y = y0; vx = vx0; vy = vy0; m = m0; d = d0;
         ax = 0; ay = 0;
         color = c;
         trail.Enqueue(new PointF(Convert.ToSingle(x / 100), Convert.ToSingle(y / 100)));
      }
      
      public void EnTrail() {
         trail.Enqueue(new PointF(Convert.ToSingle(x / 100), Convert.ToSingle(y / 100)));
         if(trail.Count > 2000) {
            trail.Dequeue();
         }
      }
   } 
}
