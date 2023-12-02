using System;

class Calculatrice
{
    static void Main(string[] args)
    {
        while (true) {
            Console.WriteLine("Entrez une opération :");
            string operation = Console.ReadLine();

            double resultat = EvaluerOperation(operation);

            Console.WriteLine("Résultat : " + resultat);
        }
        

    }

    static double EvaluerOperation(string operation)
    {
     
            // Supprimer les espaces de l'opération
            operation = operation.Replace(" ", "");

            var dataTable = new System.Data.DataTable();
            var result = dataTable.Compute(operation, "");

            return Convert.ToDouble(result);
  
       
    }
}