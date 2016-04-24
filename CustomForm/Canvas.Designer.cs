namespace SimpleGrav {
   partial class Canvas {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.sidebar = new System.Windows.Forms.Panel();
         this.Reset = new System.Windows.Forms.Button();
         this.timestep = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.SimMethod = new System.Windows.Forms.ComboBox();
         this.IntMethod = new System.Windows.Forms.ComboBox();
         this.Start = new System.Windows.Forms.Button();
         this.FPSCounter = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.mass = new System.Windows.Forms.TextBox();
         this.ObjCounter = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.UpdateInput = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.vel_y = new System.Windows.Forms.TextBox();
         this.vel_x = new System.Windows.Forms.TextBox();
         this.sidebar.SuspendLayout();
         this.SuspendLayout();
         // 
         // sidebar
         // 
         this.sidebar.BackColor = System.Drawing.Color.DarkGray;
         this.sidebar.Controls.Add(this.Reset);
         this.sidebar.Controls.Add(this.timestep);
         this.sidebar.Controls.Add(this.label5);
         this.sidebar.Controls.Add(this.SimMethod);
         this.sidebar.Controls.Add(this.IntMethod);
         this.sidebar.Controls.Add(this.Start);
         this.sidebar.Controls.Add(this.FPSCounter);
         this.sidebar.Controls.Add(this.label6);
         this.sidebar.Controls.Add(this.label4);
         this.sidebar.Controls.Add(this.mass);
         this.sidebar.Controls.Add(this.ObjCounter);
         this.sidebar.Controls.Add(this.label3);
         this.sidebar.Controls.Add(this.UpdateInput);
         this.sidebar.Controls.Add(this.label2);
         this.sidebar.Controls.Add(this.label1);
         this.sidebar.Controls.Add(this.vel_y);
         this.sidebar.Controls.Add(this.vel_x);
         this.sidebar.Dock = System.Windows.Forms.DockStyle.Right;
         this.sidebar.Location = new System.Drawing.Point(793, 0);
         this.sidebar.Name = "sidebar";
         this.sidebar.Size = new System.Drawing.Size(168, 531);
         this.sidebar.TabIndex = 2;
         // 
         // Reset
         // 
         this.Reset.Location = new System.Drawing.Point(27, 486);
         this.Reset.Name = "Reset";
         this.Reset.Size = new System.Drawing.Size(128, 25);
         this.Reset.TabIndex = 16;
         this.Reset.Text = "Reset Simulation";
         this.Reset.UseVisualStyleBackColor = true;
         this.Reset.Click += new System.EventHandler(this.Reset_Click);
         // 
         // timestep
         // 
         this.timestep.AutoSize = true;
         this.timestep.Location = new System.Drawing.Point(70, 48);
         this.timestep.Name = "timestep";
         this.timestep.Size = new System.Drawing.Size(34, 13);
         this.timestep.TabIndex = 15;
         this.timestep.Text = "0.001";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(11, 48);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(53, 13);
         this.label5.TabIndex = 14;
         this.label5.Text = "Timestep:";
         // 
         // SimMethod
         // 
         this.SimMethod.FormattingEnabled = true;
         this.SimMethod.Items.AddRange(new object[] {
            "Brute Force"});
         this.SimMethod.Location = new System.Drawing.Point(27, 399);
         this.SimMethod.Name = "SimMethod";
         this.SimMethod.Size = new System.Drawing.Size(127, 21);
         this.SimMethod.TabIndex = 13;
         this.SimMethod.Text = "Simulation Method";
         // 
         // IntMethod
         // 
         this.IntMethod.FormattingEnabled = true;
         this.IntMethod.Items.AddRange(new object[] {
            "Euler Integration",
            "Verlet Integration"});
         this.IntMethod.Location = new System.Drawing.Point(27, 372);
         this.IntMethod.Name = "IntMethod";
         this.IntMethod.Size = new System.Drawing.Size(127, 21);
         this.IntMethod.TabIndex = 12;
         this.IntMethod.Text = "Integration Method";
         // 
         // Start
         // 
         this.Start.Location = new System.Drawing.Point(27, 455);
         this.Start.Name = "Start";
         this.Start.Size = new System.Drawing.Size(128, 25);
         this.Start.TabIndex = 11;
         this.Start.Text = "Start Simulation";
         this.Start.UseVisualStyleBackColor = true;
         this.Start.Click += new System.EventHandler(this.Start_Click);
         // 
         // FPSCounter
         // 
         this.FPSCounter.AutoSize = true;
         this.FPSCounter.Location = new System.Drawing.Point(70, 19);
         this.FPSCounter.Name = "FPSCounter";
         this.FPSCounter.Size = new System.Drawing.Size(28, 13);
         this.FPSCounter.TabIndex = 10;
         this.FPSCounter.Text = "0.00";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(10, 19);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(30, 13);
         this.label6.TabIndex = 9;
         this.label6.Text = "FPS:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(25, 164);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(32, 13);
         this.label4.TabIndex = 8;
         this.label4.Text = "Mass";
         // 
         // mass
         // 
         this.mass.Location = new System.Drawing.Point(56, 161);
         this.mass.Name = "mass";
         this.mass.Size = new System.Drawing.Size(100, 20);
         this.mass.TabIndex = 7;
         // 
         // ObjCounter
         // 
         this.ObjCounter.AutoSize = true;
         this.ObjCounter.Location = new System.Drawing.Point(70, 81);
         this.ObjCounter.Name = "ObjCounter";
         this.ObjCounter.Size = new System.Drawing.Size(13, 13);
         this.ObjCounter.TabIndex = 6;
         this.ObjCounter.Text = "0";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(11, 81);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(46, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "Objects:";
         // 
         // UpdateInput
         // 
         this.UpdateInput.Location = new System.Drawing.Point(28, 187);
         this.UpdateInput.Name = "UpdateInput";
         this.UpdateInput.Size = new System.Drawing.Size(128, 25);
         this.UpdateInput.TabIndex = 4;
         this.UpdateInput.Text = "Change Parameters";
         this.UpdateInput.UseVisualStyleBackColor = true;
         this.UpdateInput.Click += new System.EventHandler(this.UpdateInput_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(35, 136);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(19, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Vy";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(35, 110);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(19, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Vx";
         // 
         // vel_y
         // 
         this.vel_y.Location = new System.Drawing.Point(57, 133);
         this.vel_y.Name = "vel_y";
         this.vel_y.Size = new System.Drawing.Size(100, 20);
         this.vel_y.TabIndex = 1;
         // 
         // vel_x
         // 
         this.vel_x.Location = new System.Drawing.Point(57, 107);
         this.vel_x.Name = "vel_x";
         this.vel_x.Size = new System.Drawing.Size(100, 20);
         this.vel_x.TabIndex = 0;
         // 
         // Canvas
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Black;
         this.ClientSize = new System.Drawing.Size(961, 531);
         this.Controls.Add(this.sidebar);
         this.DoubleBuffered = true;
         this.MaximizeBox = false;
         this.Name = "Canvas";
         this.Text = "SimpleGravity";
         this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseClick);
         this.Resize += new System.EventHandler(this.Canvas_Resize);
         this.sidebar.ResumeLayout(false);
         this.sidebar.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel sidebar;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox vel_y;
      private System.Windows.Forms.TextBox vel_x;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox mass;
      private System.Windows.Forms.Label ObjCounter;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button UpdateInput;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox SimMethod;
      private System.Windows.Forms.ComboBox IntMethod;
      private System.Windows.Forms.Button Start;
      private System.Windows.Forms.Label FPSCounter;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label timestep;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button Reset;
   }
}

