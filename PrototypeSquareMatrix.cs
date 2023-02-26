﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
  class PrototypeSquareMatrix : SquareMatrix, ICloneable {
    public PrototypeSquareMatrix(int Side) : base(Side) { }
    public PrototypeSquareMatrix() : base() { }

    public object Clone() {
      PrototypeSquareMatrix Result = new PrototypeSquareMatrix(Side);

      Result.Side = this.Side;
      Result.ArraySquare = this.ArraySquare;

      return Result;
    }
  }
}
