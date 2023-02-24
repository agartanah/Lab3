using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
  class SquareMatrix {
    int Side;
    double[,] ArraySquare;
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

    public static SquareMatrix operator +(SquareMatrix MatrixLeft, SquareMatrix MatrixRight) {
      SquareMatrix MatrixResult = new SquareMatrix(MatrixLeft.Side);

      for (int RowIndex = 0; RowIndex < MatrixLeft.Side; RowIndex++) {
        for (int ColumnIndex = 0; ColumnIndex < MatrixLeft.Side; ColumnIndex++) {
          MatrixResult.ArraySquare[RowIndex, ColumnIndex] = MatrixLeft.ArraySquare[RowIndex, ColumnIndex] +
            MatrixRight.ArraySquare[RowIndex, ColumnIndex];
        }
      }

      return MatrixResult;
    }

    public static SquareMatrix operator -(SquareMatrix MatrixLeft, SquareMatrix MatrixRight) {
      SquareMatrix MatrixResult = new SquareMatrix(MatrixLeft.Side);

      for (int RowIndex = 0; RowIndex < MatrixLeft.Side; RowIndex++) {
        for (int ColumnIndex = 0; ColumnIndex < MatrixLeft.Side; ColumnIndex++) {
          MatrixResult.ArraySquare[RowIndex, ColumnIndex] = MatrixLeft.ArraySquare[RowIndex, ColumnIndex] -
            MatrixRight.ArraySquare[RowIndex, ColumnIndex];
        }
      }

      return MatrixResult;
    }

    public static SquareMatrix operator *(SquareMatrix MatrixLeft, SquareMatrix MatrixRight) {
      SquareMatrix MatrixResult = new SquareMatrix(MatrixLeft.Side);

      for (int RowIndex = 0; RowIndex < MatrixLeft.Side; RowIndex++) {
        for (int ColumnIndex = 0; ColumnIndex < MatrixLeft.Side; ColumnIndex++) {
          MatrixResult.ArraySquare[RowIndex, ColumnIndex] = MatrixLeft.ArraySquare[RowIndex, ColumnIndex] *
            MatrixRight.ArraySquare[RowIndex, ColumnIndex];
        }
      }

      return MatrixResult;
    }
    
    public static bool operator <(SquareMatrix MatrixLeft, SquareMatrix MatrixRight) {
      double MatrixLeftSum = default, MatrixRightSum = default;

      foreach (var MatrixElement in MatrixLeft.ArraySquare) {
        MatrixLeftSum += MatrixElement;
      }
      foreach (var MatrixElement in MatrixRight.ArraySquare) {
        MatrixRightSum += MatrixElement;
      }

      if (MatrixLeftSum < MatrixRightSum) {
        return true;
      } else {
        return false;
      }
    }

    public static bool operator >(SquareMatrix MatrixLeft, SquareMatrix MatrixRight) {
      double MatrixLeftSum = default, MatrixRightSum = default;

      foreach (var MatrixElement in MatrixLeft.ArraySquare) {
        MatrixLeftSum += MatrixElement;
      }
      foreach (var MatrixElement in MatrixRight.ArraySquare) {
        MatrixRightSum += MatrixElement;
      }

      if (MatrixLeftSum > MatrixRightSum) {
        return true;
      } else {
        return false;
      }
    }

    public static bool operator <=(SquareMatrix MatrixLeft, SquareMatrix MatrixRight) {
      double MatrixLeftSum = default, MatrixRightSum = default;

      foreach (var MatrixElement in MatrixLeft.ArraySquare) {
        MatrixLeftSum += MatrixElement;
      }
      foreach (var MatrixElement in MatrixRight.ArraySquare) {
        MatrixRightSum += MatrixElement;
      }

      if (MatrixLeftSum <= MatrixRightSum) {
        return true;
      } else {
        return false;
      }
    }

    public static bool operator >=(SquareMatrix MatrixLeft, SquareMatrix MatrixRight) {
      double MatrixLeftSum = default, MatrixRightSum = default;

      foreach (var MatrixElement in MatrixLeft.ArraySquare) {
        MatrixLeftSum += MatrixElement;
      }
      foreach (var MatrixElement in MatrixRight.ArraySquare) {
        MatrixRightSum += MatrixElement;
      }

      if (MatrixLeftSum >= MatrixRightSum) {
        return true;
      } else {
        return false;
      }
    }

    public static bool operator ==(SquareMatrix MatrixLeft, SquareMatrix MatrixRight) {
      double MatrixLeftSum = default, MatrixRightSum = default;

      foreach (var MatrixElement in MatrixLeft.ArraySquare) {
        MatrixLeftSum += MatrixElement;
      }
      foreach (var MatrixElement in MatrixRight.ArraySquare) {
        MatrixRightSum += MatrixElement;
      }

      if (MatrixLeftSum == MatrixRightSum) {
        return true;
      } else {
        return false;
      }
    }

    public static bool operator !=(SquareMatrix MatrixLeft, SquareMatrix MatrixRight) {
      double MatrixLeftSum = default, MatrixRightSum = default;

      foreach (var MatrixElement in MatrixLeft.ArraySquare) {
        MatrixLeftSum += MatrixElement;
      }
      foreach (var MatrixElement in MatrixRight.ArraySquare) {
        MatrixRightSum += MatrixElement;
      }

      if (MatrixLeftSum != MatrixRightSum) {
        return true;
      } else {
        return false;
      }
    }

    public static bool operator true(SquareMatrix Matrix) {
      foreach (var MatrixElement in Matrix.ArraySquare) {
        if (MatrixElement != 0) {
          return true;
        }
      }
      return false;
    }

    public static bool operator false(SquareMatrix Matrix) {
      foreach (var MatrixElement in Matrix.ArraySquare) {
        if (MatrixElement == 0) {
          return true;
        }
      }
      return false;
    }


  }
}
