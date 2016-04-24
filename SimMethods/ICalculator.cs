using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGrav {
   interface ICalculator {
      List<Body> bodies { get; set; }
      void AddBody(Body body);
      void UpdatePositions(Double dt);
      void InitParams(Double dt);
      void Reset();
   }
}
