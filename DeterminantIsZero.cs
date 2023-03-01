using System;

namespace Lab3 {
  class DeterminantIsZero : Exception {
    public DeterminantIsZero() : base() { }
    public DeterminantIsZero(string Message) : base(Message) { }

  }
}
