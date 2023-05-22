namespace Lab3 {
  public static class ExtensionMethods {
    public static void Transpose(ref SquareMatrix Matrix) {
      for (int RowIndex = 0; RowIndex < Matrix.Side; ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex < Matrix.Side; ++ColumnIndex) {
          if (RowIndex != ColumnIndex) {
            double Element = Matrix.ArraySquare[RowIndex, ColumnIndex];

            Matrix.ArraySquare[RowIndex, ColumnIndex] = Matrix.ArraySquare[ColumnIndex, RowIndex];
            Matrix.ArraySquare[ColumnIndex, RowIndex] = Element;
          }
        }
      }
    }

    public static double MatrixTrace(SquareMatrix Matrix) {
      double SumOfDiagonalElements = default;

      for (int RowIndex = 0; RowIndex < Matrix.Side; ++RowIndex) {
        for (int ColumnIndex = 0; ColumnIndex <= RowIndex; ++ColumnIndex) {
          SumOfDiagonalElements += Matrix.ArraySquare[RowIndex, ColumnIndex];
        }
      }

      return SumOfDiagonalElements;
    }
  }
}
