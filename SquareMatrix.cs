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

    public SquareMatrix() {
      int Side = 2;
      ArraySquare = new double[Side, Side];

      for (int RowIndex = 0; RowIndex < Side; ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Side; ++ColumnIndex) {
          ArraySquare[RowIndex, ColumnIndex] = ValRandom.Next(100);
        }
      }
    }

    public SquareMatrix(int Side) {
      this.Side = Side;

      if (Side == 0) {
        throw new MatrixSideIsZero("Side of Matrix Equal of Zero!");
      }

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
      if(MatrixLeft.Side != MatrixRight.Side) {
        throw new DifferentSides("Matrixes have different sides!\n\tIt is impossible to perform an operation!");
      }
      
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
      if (MatrixLeft.Side != MatrixRight.Side) {
        throw new DifferentSides("Matrixes have different sides!\n\tIt is impossible to perform an operation!");
      }

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
      if (MatrixLeft.Side != MatrixRight.Side) {
        throw new DifferentSides("Matrixes have different sides!\n\tIt is impossible to perform an operation!");
      }

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

    public static implicit operator string[,](SquareMatrix Matrix) {
      string[,] MatrixString = new string[Matrix.Side, Matrix.Side];

      for (int RowIndex = 0; RowIndex < Matrix.Side; ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Matrix.Side; ColumnIndex++) {
          MatrixString[RowIndex, ColumnIndex] = Matrix.ArraySquare[RowIndex, ColumnIndex].ToString();
        }
      }

      return MatrixString;
    }

    public static implicit operator int[,](SquareMatrix Matrix) {
      int[,] MatrixString = new int[Matrix.Side, Matrix.Side];

      for (int RowIndex = 0; RowIndex < Matrix.Side; ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Matrix.Side; ColumnIndex++) {
          MatrixString[RowIndex, ColumnIndex] = (int)Matrix.ArraySquare[RowIndex, ColumnIndex];
        }
      }

      return MatrixString;
    }

    public static implicit operator double[,](SquareMatrix Matrix) {
      double[,] MatrixString = new double[Matrix.Side, Matrix.Side];

      for (int RowIndex = 0; RowIndex < Matrix.Side; ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Matrix.Side; ColumnIndex++) {
          MatrixString[RowIndex, ColumnIndex] = (double)Matrix.ArraySquare[RowIndex, ColumnIndex];
        }
      }

      return MatrixString;
    }

    public static implicit operator SquareMatrix(double[,] Matrix) {
      SquareMatrix MatrixClass = new SquareMatrix((int)Math.Sqrt(Matrix.Length));

      for (int RowIndex = 0; RowIndex < Math.Sqrt(Matrix.Length); ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Math.Sqrt(Matrix.Length); ++ColumnIndex) {
          MatrixClass.ArraySquare[RowIndex, ColumnIndex] = Matrix[RowIndex, ColumnIndex];
        }
      }

      return MatrixClass;
    }

    public static implicit operator SquareMatrix(int[,] Matrix) {
      SquareMatrix MatrixClass = new SquareMatrix((int)Math.Sqrt(Matrix.Length));

      for (int RowIndex = 0; RowIndex < Math.Sqrt(Matrix.Length); ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Math.Sqrt(Matrix.Length); ++ColumnIndex) {
          MatrixClass.ArraySquare[RowIndex, ColumnIndex] = Matrix[RowIndex, ColumnIndex];
        }
      }

      return MatrixClass;
    }

    public static void Transposition(ref int[,] Matrix, int MatrixSide) {
      for (int RowIndex = 0; RowIndex < MatrixSide; RowIndex++) {
        for (int ColumnIndex = 0; ColumnIndex < MatrixSide; ColumnIndex++) {
          if (RowIndex != ColumnIndex) {
            int Element = Matrix[RowIndex, ColumnIndex];

            Matrix[RowIndex, ColumnIndex] = Matrix[ColumnIndex, RowIndex];
            Matrix[ColumnIndex, RowIndex] = Element;
          }
        }
      }
    }

    public static void Transposition(ref double[,] Matrix, int MatrixSide) {
      for (int RowIndex = 0; RowIndex < MatrixSide; RowIndex++) {
        for (int ColumnIndex = 0; ColumnIndex < MatrixSide; ColumnIndex++) {
          if (RowIndex != ColumnIndex) {
            double Element = Matrix[RowIndex, ColumnIndex];

            Matrix[RowIndex, ColumnIndex] = Matrix[ColumnIndex, RowIndex];
            Matrix[ColumnIndex, RowIndex] = Element;
          }
        }
      }
    }

    public static SquareMatrix operator -(SquareMatrix Matrix) {
      SquareMatrix MatrixResult = new SquareMatrix(Matrix.Side);
      double MatrixDeterminant = Determinant(Matrix.ArraySquare, Matrix.Side);
      if (MatrixDeterminant == 0) {
        throw new DeterminantIsZero("The determinant is zero! It is impossible to calculate the inverse matrix!");
      }
      double[,] MatrixAlgebraicComplement = new double[Matrix.Side, Matrix.Side];

      for (int RowElementsIndex = 0; RowElementsIndex < Matrix.Side; ++RowElementsIndex) {
        for (int ColumnElementsIndex = 0; ColumnElementsIndex < Matrix.Side; ++ColumnElementsIndex) {
          double[,] MatrixInAlgebraicComplement = new double[Matrix.Side - 1, Matrix.Side - 1];
          int MatrixInAlgebraicComplementRowIndex = default;

          for (int RowIndex = 0; RowIndex < Matrix.Side; ++RowIndex) {
            int MatrixInAlgebraicComplementColumnIndex = default;

            if (RowIndex != RowElementsIndex) {
              for (int ColumnIndex = 0; ColumnIndex < Matrix.Side; ++ColumnIndex) {
                if (ColumnIndex != ColumnElementsIndex) {
                  MatrixInAlgebraicComplement[MatrixInAlgebraicComplementRowIndex, MatrixInAlgebraicComplementColumnIndex] =
                    Matrix.ArraySquare[RowIndex, ColumnIndex];
                  ++MatrixInAlgebraicComplementColumnIndex;
                }
              }

              ++MatrixInAlgebraicComplementRowIndex;
            }
          }

          MatrixAlgebraicComplement[RowElementsIndex, ColumnElementsIndex] =
            Determinant(MatrixInAlgebraicComplement, Matrix.Side - 1);
        }
      }

      for (int RowIndex = 0; RowIndex < Matrix.Side; ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Matrix.Side; ColumnIndex++) {
          MatrixAlgebraicComplement[RowIndex, ColumnIndex] *= (1 / MatrixDeterminant);
        }
      }

      MatrixResult = MatrixAlgebraicComplement;

      return MatrixResult;
    }

    public static double Determinant(int[,] Matrix, int MatrixSide) {

      if (MatrixSide == 2) {
        return (Matrix[0, 0] * Matrix[1, 1] -
          Matrix[0, 1] * Matrix[1, 0]);
      } else if (MatrixSide == 1) {
        return Matrix[0, 0];
      } else if (MatrixSide >= 3) {
        int[,] MatrixForDeterminant = new int[MatrixSide - 1, MatrixSide - 1];
        double MatrixDeterminant = default;

        int MatrixForDeterminantRowIndex, MatrixForDeterminantColumnIndex;

        for (int RowElementsIndex = 0; RowElementsIndex < MatrixSide; ++RowElementsIndex) {
          MatrixForDeterminantRowIndex = default;

          for (int RowIndex = 1; RowIndex < MatrixSide; ++RowIndex) {
            MatrixForDeterminantColumnIndex = default;

            for (int ColumnIndex = 0; ColumnIndex < MatrixSide; ++ColumnIndex) {
              if (ColumnIndex != RowElementsIndex) {
                MatrixForDeterminant[MatrixForDeterminantRowIndex, MatrixForDeterminantColumnIndex] =
                  Matrix[RowIndex, ColumnIndex];
                ++MatrixForDeterminantColumnIndex;
              }
            }

            ++MatrixForDeterminantRowIndex;
          }

          MatrixDeterminant += Math.Pow(-1, RowElementsIndex + 2) * Matrix[0, RowElementsIndex]
            * Determinant(MatrixForDeterminant, MatrixSide - 1);
        }

        return MatrixDeterminant;
      } else {
        throw new MatrixSideIsZero("The side of a square matrix is zero! Incorrect side value!");
      }
    }

    public static double Determinant(double[,] Matrix, int MatrixSide) {

      if (MatrixSide == 2) {
        return (Matrix[0, 0] * Matrix[1, 1] -
          Matrix[0, 1] * Matrix[1, 0]);
      } else if (MatrixSide == 1) {
        return Matrix[0, 0];
      } else if (MatrixSide >= 3) {
        double[,] MatrixForDeterminant = new double[MatrixSide - 1, MatrixSide - 1];
        double MatrixDeterminant = default;

        int MatrixForDeterminantRowIndex, MatrixForDeterminantColumnIndex;

        for (int RowElementsIndex = 0; RowElementsIndex < MatrixSide; ++RowElementsIndex) {
          MatrixForDeterminantRowIndex = default;

          for (int RowIndex = 1; RowIndex < MatrixSide; ++RowIndex) {
            MatrixForDeterminantColumnIndex = default;

            for (int ColumnIndex = 0; ColumnIndex < MatrixSide; ++ColumnIndex) {
              if (ColumnIndex != RowElementsIndex) {
                MatrixForDeterminant[MatrixForDeterminantRowIndex, MatrixForDeterminantColumnIndex] =
                  Matrix[RowIndex, ColumnIndex];
                ++MatrixForDeterminantColumnIndex;
              }
            }

            ++MatrixForDeterminantRowIndex;
          }

          MatrixDeterminant += Math.Pow(-1, RowElementsIndex + 2) * Matrix[0, RowElementsIndex]
            * Determinant(MatrixForDeterminant, MatrixSide - 1);
        }

        return MatrixDeterminant;
      } else {
        throw new MatrixSideIsZero("The side of a square matrix is zero! Incorrect side value!");
      }
    }

    public static double operator +(SquareMatrix Matrix) {
      double MatrixDeterminant;

      MatrixDeterminant = Determinant(Matrix.ArraySquare, Matrix.Side);

      return MatrixDeterminant;
    }

    public override string ToString() {
      string MatrixString = "";

      for (int RowIndex = 0; RowIndex < Side; ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Side; ++ColumnIndex) {
          MatrixString += ArraySquare[RowIndex, ColumnIndex].ToString() + "\t";
        }
        MatrixString += "\n";
      }

      return MatrixString;
    }

    public int CompareTo(SquareMatrix Matrix) {
      double MatrixSum1 = default, MatrixSum2 = default;

      foreach (var MatrixElement in ArraySquare) {
        MatrixSum1 += (double)MatrixElement;
      }
      foreach (var MatrixElement in Matrix.ArraySquare) {
        MatrixSum2 += (double)MatrixElement;
      }

      if (MatrixSum1 > MatrixSum2) {
        return 1;
      } else if (MatrixSum1 == MatrixSum2) {
        return 0;
      } else {
        return -1;
      }
    }

    public bool Equals(SquareMatrix Matrix) {
      for (int RowIndex = 0; RowIndex < Side; ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Side; ++ColumnIndex) {
          if (ArraySquare[RowIndex, ColumnIndex] != Matrix.ArraySquare[RowIndex, ColumnIndex]) {
            return false;
          }
        }
      }
      return true;
    }

    public override int GetHashCode() {
      return ArraySquare.GetHashCode();
    }
  }
}
