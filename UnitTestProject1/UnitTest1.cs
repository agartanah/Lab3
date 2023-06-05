using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1 {
  [TestClass]
  public class UnitTest1 {
    Lab3.SquareMatrix Matrix = new Lab3.SquareMatrix(3);

    [TestMethod]
    public void TestTriangleMethod() {
      Lab3.SquareMatrix MatrixTest = Matrix;

      Lab3.SquareMatrix.TriangleMatrix(MatrixTest);

      bool ZeroTriangle = false;
      if (Matrix.ArraySquare[1, 0] == 0 && Matrix.ArraySquare[2, 0] == 0 && Matrix.ArraySquare[2, 1] == 0) {
        ZeroTriangle = true;
      }

      Assert.IsTrue(ZeroTriangle);
    }

    [TestMethod]
    public void TestTranspositionMethod() {

      Lab3.SquareMatrix MatrixTest = new Lab3.SquareMatrix(3);
      Array.Copy(Matrix.ArraySquare, MatrixTest.ArraySquare, Matrix.ArraySquare.Length);

      MatrixTest.ArraySquare = MatrixTest.Transposition();

      Console.WriteLine(MatrixTest);
      Console.WriteLine(Matrix);

      bool EqualElement = true;
      for (int RowIndex = 0; RowIndex < Matrix.Side; ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Matrix.Side; ++ColumnIndex) {
          if (RowIndex != ColumnIndex && Matrix.ArraySquare[RowIndex, ColumnIndex] != MatrixTest.ArraySquare[ColumnIndex, RowIndex]) {
            EqualElement = false;
            break;
          }
        }

        if (!EqualElement) {
          break;
        }
      }

      Assert.IsTrue(EqualElement);
    }

    [TestMethod]
    public void TestDeterminantMethod() {
      Assert.IsNotNull(Lab3.SquareMatrix.Determinant(Matrix.ArraySquare, Matrix.Side));
    }

    [TestMethod]
    public void TestCompareToMethod() {
      Lab3.SquareMatrix MatrixTest = Matrix;

      Assert.AreEqual(Matrix.CompareTo(MatrixTest), 0);
    }

    [TestMethod]
    public void TestEqualsMethod() {
      Lab3.SquareMatrix MatrixTest = Matrix;

      Assert.IsTrue(Matrix.Equals(MatrixTest));
    }

    [TestMethod]
    public void TestGetHashCodeMethod() {
      Assert.AreEqual(Matrix.GetHashCode(), Matrix.ArraySquare.GetHashCode());
    }
  }
}
