using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
  class DifferentSides : Exception {
    public DifferentSides() : base() { } 
    public DifferentSides(string Message) : base() { }
  }
}
