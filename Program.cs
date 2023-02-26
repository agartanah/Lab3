using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
  class Program {
    static void Main(string[] args) {
      Console.Write("Введите сторону матриц: ");
      int Side = int.Parse(Console.ReadLine());

      SquareMatrix Matrix1 = new SquareMatrix(Side);
      SquareMatrix Matrix2 = new SquareMatrix(Side);

      Console.WriteLine($"Ваши матрицы:\n{Matrix1}\n{Matrix2}\n");

      Console.WriteLine("Что с ними делать?\n\t1. Сложить\n\t2. Вычесть вторую из первой\n\t" +
        "3. Вычесть первую из второй\n\t4. Пермножить\n\t5. Найти Детерминанту желаемой матрицы\n\t" +
        "6. Найти матрицу Обратную желаемой\n");
      Console.Write("Введите желаемый пункт: ");
      int UserChoice = int.Parse(Console.ReadLine());

      switch (UserChoice) {
        case 1:
          Console.WriteLine($"Сумма матриц равна:\n{Matrix1 + Matrix2}");
          break;
        case 2:
          Console.WriteLine($"Разность (Первая - Вторая) равна:\n{Matrix1 - Matrix2}");
          break;
        case 3:
          Console.WriteLine($"Разность (Вторая - Первая) равна:\n{Matrix2 - Matrix1}");
          break;
        case 4:
          Console.WriteLine($"Произведение матриц равно:\n{Matrix1 * Matrix2}");
          break;
        case 5:
          Console.WriteLine($"Выберите одну из матриц:\n   1.\n{Matrix1}\n   2.\n{Matrix2}");
          Console.WriteLine("Введите номер матрицы, Детерминант которой хотите вычислить:\n");
          int UserChoice2 = int.Parse(Console.ReadLine());

          if (UserChoice2 == 1) {
            Console.WriteLine($"Детерминант матрицы №{UserChoice2} равен: {+Matrix1}");
          } else if (UserChoice2 == 2) {
            Console.WriteLine($"Детерминант матрицы №{UserChoice2} равен: {+Matrix2}");
          } else {
            Console.WriteLine("Нет матрицы под таким номером! Попробуйте снова!");
          }

          break;
        case 6:
          Console.WriteLine($"Выберите одну из матриц:\n   1.\n{Matrix1}\n   2.\n{Matrix2}");
          Console.WriteLine("Введите номер матрицы, Обратную матрицу которой хотите найти:\n");
          int UserChoice3 = int.Parse(Console.ReadLine());

          if (UserChoice3 == 1) {
            Console.WriteLine($"Обратной матрицей матрицы №{UserChoice3} является:\n{-Matrix1}");
          } else if (UserChoice3 == 2) {
            Console.WriteLine($"Обратной матрицей матрицы №{UserChoice3} является:\n{-Matrix2}");
          } else {
            Console.WriteLine("Нет матрицы под таким номером! Попробуйте снова!");
          }

          break;
        default:
          Console.WriteLine("Введён неверный пункт! Попробуйте снова!");
          break;
      }
    }
  }
}
