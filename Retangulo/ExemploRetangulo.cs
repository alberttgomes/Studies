namespace ExemploRetangulo
{
     public class Retangulo
     {
         private double largura {get; set;}
         private double comprimento {get; set; }
         private bool valido;

         public void DefinirMedidas(double comprimento, double largura)
         {
             if (comprimento > 0 && largura > 0)
             {
                 this.comprimento = comprimento;
                 this.largura = largura;
                 valido = true;
             }
             else
             {
                  System.Console.WriteLine("Valor inválido!");
             }
             
         }

         public double ObterArea()
         {
             if (valido)
             {
                 return comprimento * largura;
             }
             else
             {
                 System.Console.WriteLine("Preencha varoles válidos");
             }
             return 0;
         }
     }

}