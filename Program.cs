  double etanol, gasolina, razao;
  Console.Clear();
  Console.ForegroundColor = ConsoleColor.DarkGreen;
  Console.WriteLine("--- Etanol ou Gasolina? ---\n");
  Console.ResetColor();
  Console.Write("Digite o preço do etanol (R$).....: ");
  etanol = Convert.ToDouble(Console.ReadLine());
  
  Console.Write("Digite o preço da gasolina (R$)...: ");
  gasolina = Convert.ToDouble(Console.ReadLine());
    
  razao = razaoPercentual(etanol, gasolina);
    
  Console.WriteLine($"\nO preço do etanol corresponde a {razao:N2}% do preço da gasolina.");

  razao = razaoRecomendacao(etanol, gasolina);
  if (razao < 73)
  {
    Console.WriteLine($"\nRecomendação: Abasteça com ETANOL.");
  }

  else
  {
   Console.WriteLine($"\nRecomendação: Abasteça com GASOLINA.");
  }

  double razaoPercentual(double etanol, double gasolina)
  {
  double valorRazao = (etanol / gasolina) * 100; 
  return valorRazao;
  }

  double razaoRecomendacao(double vlEtanol, double vlGasolina)
  {
    double resultadoRazao = (vlEtanol / vlGasolina) * 100;
    return resultadoRazao;
  }