using System;

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
        "6. Найти матрицу Обратную желаемой\n\t7. Привести матрицу к треугольному виду\n");
      Console.Write("Введите желаемый пункт: ");
      int UserChoice = int.Parse(Console.ReadLine());

      Start Hand = new Start();
      
      Hand.HandleD(Matrix1, Matrix2, UserChoice); // запуск цепочки обязанностей

      Console.ReadKey();
    }
  }
}
