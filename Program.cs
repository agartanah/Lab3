using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
  class Program {
    static void Main(string[] args) {
      int Side = int.Parse(Console.ReadLine());

      SquareMatrix Array1 = new SquareMatrix(Side);
      SquareMatrix Array2 = new SquareMatrix(Side);

      Array1.PrintMatrix();
      Array2.PrintMatrix();
    }
  }
}
