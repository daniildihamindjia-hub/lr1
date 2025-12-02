using System;

class LogicalOperations
{
    
    public static bool Not(bool a)
    {
        return !a;
    }

    
    public static bool And(bool a, bool b)
    {
        return a && b;
    }

    
    public static bool Or(bool a, bool b)
    {
        return a || b;
    }

    
    
    public static bool Implication(bool a, bool b)
    {
       
        
        return !a || b;
    }

    
   
    public static bool Equivalence(bool a, bool b)
    {
        
        return a == b;
        
        
        
    }

    // Функция для тестирования всех операций
    public static void TestOperations()
    {
        Console.WriteLine("--- Тестирование логических операций ---");

        // Тестирование операции НЕ
        Console.WriteLine("\n--- Операция НЕ (NOT) ---");
        Console.WriteLine($"НЕ True  = {Not(true)}");
        Console.WriteLine($"НЕ False = {Not(false)}");

         // (таблица истинности)
        bool[] values = { false, true };

        Console.WriteLine("\n--- Таблицы истинности для бинарных операций ---");

        Console.WriteLine("| A     | B     | A И B | A ИЛИ B | A => B | A <=> B |");
        Console.WriteLine("|-------|-------|-------|---------|--------|---------|");

        foreach (bool a in values)
        {
            foreach (bool b in values)
            {
                bool andResult = And(a, b);
                bool orResult = Or(a, b);
                bool implicationResult = Implication(a, b);
                bool equivalenceResult = Equivalence(a, b);

                Console.WriteLine($"| {a.ToString().PadRight(5)} | {b.ToString().PadRight(5)} | {andResult.ToString().PadRight(5)} | {orResult.ToString().PadRight(7)} | {implicationResult.ToString().PadRight(6)} | {equivalenceResult.ToString().PadRight(7)} |");
            }
        }
    }

    // Точка входа в программу
    static void Main(string[] args)
    {
        TestOperations();
    }
}
