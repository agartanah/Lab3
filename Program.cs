using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
  class Program {
    static void Main(string[] args) {
      int Side = int.Parse(Console.ReadLine());
      PrototypeSquareMatrix Matrix1 = new PrototypeSquareMatrix(Side);
      
      PrototypeSquareMatrix Matrix2 = (PrototypeSquareMatrix)Matrix1.Clone();

      Console.WriteLine(Matrix1.ToString());
      Console.WriteLine(Matrix2.ToString());
    }
  }
}
