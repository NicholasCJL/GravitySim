//implements ICalculator interface

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGrav {
   //naive brute force calculation
   public class SimpleCalculator : ICalculator {
      public static bool Euler = true;
      public static bool BH = false;
      public static Double G = 1.0;
      public List<Body> bodies { get; set; } = new List<Body>();

      void ICalculator.AddBody(Body body) {
         bodies.Add(body);
      }

      void ICalculator.InitParams(Double dt) {
         for(Int32 i=0; i<bodies.Count; i++) {
            Double[] acc = acceleration(i);
            bodies[i].vx += (dt * (acc[0] + bodies[i].ax) / 2);
            bodies[i].vy += (dt * (acc[1] + bodies[i].ay) / 2);
            bodies[i].ax = acc[0];
            bodies[i].ay = acc[1];
         }
      }

      void ICalculator.UpdatePositions(Double dt) {
         //remove bodies out of bounds
         for (Int32 i=bodies.Count-1; i>=0; i--) {
            if((bodies[i].x > MainFile.canvas.xmax)|(bodies[i].x < MainFile.canvas.xmin)|(bodies[i].y > MainFile.canvas.ymax)|(bodies[i].y < MainFile.canvas.ymin)) {
               bodies.RemoveAt(i);
            } 
         }
         
         if (Euler) {
            //Euler integration
            //update position and velocities of all bodies
            for (Int32 i=0; i<bodies.Count; i++) {
               bodies[i].x += (bodies[i].vx * dt);
               bodies[i].y += (bodies[i].vy * dt);
               bodies[i].EnTrail();
               bodies[i].vx += (bodies[i].ax * dt);
               bodies[i].vy += (bodies[i].ay * dt);
            }
            //update acceleration of all bodies
            for (Int32 i=0; i<bodies.Count; i++) {
               Double[] acc = acceleration(i);
               bodies[i].ax = acc[0];
               bodies[i].ay = acc[1];
            }
         }
         else {
            //Verlet method
            //update position of all bodies
            for(Int32 i=0; i<bodies.Count; i++) {
               //dx = v*dt + 0.5*a*dt^2 
               bodies[i].x += (dt * (bodies[i].x + dt * bodies[i].ax / 2));
               bodies[i].y += (dt * (bodies[i].y + dt * bodies[i].ay / 2));
               bodies[i].EnTrail();
            }
            //update acceleration and velocity of all bodies
            for(Int32 i=0; i<bodies.Count; i++) {
               Double[] acc = acceleration(i);
               bodies[i].vx += (dt * (acc[0] + bodies[i].ax) / 2);
               bodies[i].vy += (dt * (acc[1] + bodies[i].ay) / 2);
               bodies[i].ax = acc[0];
               bodies[i].ay = acc[1];
            }
         }
      }

      private Double[] acceleration(Int32 index) {
         Double[] acc = new Double[2] { 0, 0 };
         for (Int32 i=0; i<bodies.Count; i++) {
            if(i != index) {
               Double r = DistanceTo(bodies[index], bodies[i]);
               //F_x = Gm/|r|^3 * r_x (this method uses the vector property directly, removing the need to calculate angles)
               Double acc_t = G * bodies[i].m / Math.Pow(r, 3);
               acc[0] += (acc_t * (bodies[i].x - bodies[index].x));
               acc[1] += (acc_t * (bodies[i].y - bodies[index].y));
            }
         }
         return acc;
      }

      private Double DistanceTo(Body b1, Body b2) {
         return Math.Sqrt(Math.Pow(b2.x - b1.x, 2) + Math.Pow(b2.y - b1.y, 2)) + 0.000001;
      }

      void ICalculator.Reset() {
         bodies.Clear();
      }
   }
}
