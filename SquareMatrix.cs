using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
  class SquareMatrix {
    public int Side;
    public double[,] ArraySquare;
    Random ValRandom = new Random(Guid.NewGuid().GetHashCode());
    public SquareMatrix(int Side) {
      this.Side = Side;
      ArraySquare = new double[Side, Side];

      for (int RowIndex = 0; RowIndex < Side; ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Side; ++ColumnIndex) {
          ArraySquare[RowIndex, ColumnIndex] = ValRandom.Next(100);
        }
      }
    }
    
    public void PrintMatrix() {
      foreach (var MatrixElement in ArraySquare) {
        Console.Write(MatrixElement + " ");
      }
      Console.WriteLine();
    }
  }
}
