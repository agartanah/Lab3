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

      SquareMatrix Array3 = new SquareMatrix(Side);
      Array3 = Array1 + Array2;
      Array3.PrintMatrix();

      Array3 = Array1 - Array2;
      Array3.PrintMatrix();

      Array3 = Array1 * Array2;
      Array3.PrintMatrix();

      Console.WriteLine("Array1 < Array2\t" + (Array1 < Array2));

      Console.WriteLine("Array1 > Array2\t" + (Array1 > Array2));

      Console.WriteLine("Array1 == Array2\t" + (Array1 == Array2));

      Console.WriteLine("Array1 != Array2\t" + (Array1 != Array2));

      Console.WriteLine("Array1 <= Array2\t" + (Array1 <= Array2));

      Console.WriteLine("Array1 >= Array2\t" + (Array1 >= Array2));

      string[,] ArrayString = Array3;

      foreach (var StringElement in ArrayString) {
        Console.WriteLine(StringElement + "\t");
      }

      Console.WriteLine(Array3.ToString());

      Console.WriteLine(Array3.GetHashCode());

      Console.WriteLine(+Array2);

      Console.WriteLine((-Array2).ToString());
    }
  }
}
