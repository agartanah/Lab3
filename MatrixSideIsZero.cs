using System;

namespace Lab3 {
  class MatrixSideIsZero : Exception {
    public MatrixSideIsZero() : base() { }
    public MatrixSideIsZero(string Message) : base(Message) { }
  }
}
