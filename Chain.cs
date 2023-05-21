using System;

namespace Lab3 {
  public delegate void HandleDelegate(SquareMatrix Matrix1, SquareMatrix Matrix2, int UserChoice);
  public abstract class Handler {
    public HandleDelegate HandleD;
    public Handler NextHandler { get; set; }
    public abstract void Handle(SquareMatrix Matrix1, SquareMatrix Matrix2, int UserChoice);
  }

  public class Start : Handler {
    public Start() {
      NextHandler = new Summ();
      HandleD = Handle;
    }

    public override void Handle(SquareMatrix Matrix1, SquareMatrix Matrix2, int UserChoice) {
      NextHandler.HandleD(Matrix1, Matrix2, UserChoice);
    }
  }

  public class Summ : Handler {
    public Summ() {
      NextHandler = new SubTwoOne();
      HandleD = Handle;
    }

    public override void Handle(SquareMatrix Matrix1, SquareMatrix Matrix2, int UserChoice) {
      if (UserChoice == 1) {
        Console.WriteLine($"Сумма матриц равна:\n{Matrix1 + Matrix2}");
      } else {
        NextHandler.HandleD(Matrix1, Matrix2, UserChoice);
      }
    }
  }

  public class SubTwoOne : Handler {
    
    public SubTwoOne() {
      NextHandler = new SubOneTwo();
      HandleD = Handle;
    }

    public override void Handle(SquareMatrix Matrix1, SquareMatrix Matrix2, int UserChoice) {
      if (UserChoice == 2) {
        Console.WriteLine($"Разность (Первая - Вторая) равна:\n{Matrix1 - Matrix2}");
      } else {
        NextHandler.HandleD(Matrix1, Matrix2, UserChoice);
      }
    }
  }

  public class SubOneTwo : Handler {
    public SubOneTwo() {
      NextHandler = new Mult();
      HandleD = Handle;
    }

    public override void Handle(SquareMatrix Matrix1, SquareMatrix Matrix2, int UserChoice) {
      if (UserChoice == 3) {
        Console.WriteLine($"Разность (Вторая - Первая) равна:\n{Matrix2 - Matrix1}");
      } else {
        NextHandler.HandleD(Matrix1, Matrix2, UserChoice);
      }
    }
  }

  public class Mult : Handler {
    public Mult() {
      NextHandler = new Det();
      HandleD = Handle;
    }

    public override void Handle(SquareMatrix Matrix1, SquareMatrix Matrix2, int UserChoice) {
      if (UserChoice == 4) {
        Console.WriteLine($"Произведение матриц равно:\n{Matrix1 * Matrix2}");
      } else {
        NextHandler.HandleD(Matrix1, Matrix2, UserChoice);
      }
    }
  }

  public class Det : Handler {
    public Det() {
      NextHandler = new Inverse();
      HandleD = Handle;
    }

    public override void Handle(SquareMatrix Matrix1, SquareMatrix Matrix2, int UserChoice) {
      if (UserChoice == 5) {
        Console.WriteLine($"Выберите одну из матриц:\n   1.\n{Matrix1}\n   2.\n{Matrix2}");
        Console.WriteLine("Введите номер матрицы, Детерминант которой хотите вычислить:\n");
        int UserChoice2 = int.Parse(Console.ReadLine());

        if (UserChoice2 == 1) {
          Console.WriteLine($"Детерминант матрицы №{UserChoice2} равен: {+Matrix1}");
        } else if (UserChoice2 == 2) {
          Console.WriteLine($"Детерминант матрицы №{UserChoice2} равен: {+Matrix2}");
        } else {
          Console.WriteLine("Нет матрицы под таким номером! Попробуйте снова!");
          UserChoice = int.Parse(Console.ReadLine());

          NextHandler = new Summ();
          NextHandler.HandleD(Matrix1, Matrix2, UserChoice);
        }
      } else {
        NextHandler.HandleD(Matrix1, Matrix2, UserChoice);
      }
    }
  }

  public class Inverse : Handler {
    public Inverse() {
      NextHandler = new Triangle();
      HandleD = Handle;
    }

    public override void Handle(SquareMatrix Matrix1, SquareMatrix Matrix2, int UserChoice) {
      if (UserChoice == 6) {
        Console.WriteLine($"Выберите одну из матриц:\n   1.\n{Matrix1}\n   2.\n{Matrix2}");
        Console.WriteLine("Введите номер матрицы, Обратную матрицу которой хотите найти:\n");
        int UserChoice3 = int.Parse(Console.ReadLine());

        if (UserChoice3 == 1) {
          Console.WriteLine($"Обратной матрицей матрицы №{UserChoice3} является:\n{-Matrix1}");
        } else if (UserChoice3 == 2) {
          Console.WriteLine($"Обратной матрицей матрицы №{UserChoice3} является:\n{-Matrix2}");
        } else {
          Console.WriteLine("Нет матрицы под таким номером! Попробуйте снова!");
          UserChoice = int.Parse(Console.ReadLine());

          NextHandler = new Summ();
          NextHandler.HandleD(Matrix1, Matrix2, UserChoice);
        }
      } else {
        NextHandler.HandleD(Matrix1, Matrix2, UserChoice);
      }
    }
  }

  public delegate void TriangleDelegate();
  public class Triangle : Handler {
    public delegate SquareMatrix HandleDelegate();

    public Triangle() {
      NextHandler = new Back();
      HandleD = Handle;
    }

    public override void Handle(SquareMatrix Matrix1, SquareMatrix Matrix2, int UserChoice) {
      if (UserChoice == 7) {
        TriangleDelegate Triangle = delegate {
          SquareMatrix.TriangleMatrix(Matrix1);
        };
        Triangle();
        Console.WriteLine("Матрица тругольного вида:\n");
        Matrix1.PrintMatrix();
      } else {
        NextHandler.HandleD(Matrix1, Matrix2, UserChoice);
      }
    }
  }

  public class Back : Handler{
    public Back() {
      HandleD = Handle;
    }
    public override void Handle(SquareMatrix Matrix1, SquareMatrix Matrix2, int UserChoice) {
      Console.WriteLine("Такого пункта не существует! Попробуйте ещё!");
      NextHandler = new Summ();

      Console.Write("Введите номер пункта из списка: ");
      UserChoice = int.Parse(Console.ReadLine());
      NextHandler.HandleD(Matrix1, Matrix2, UserChoice);
    }
  }
}
