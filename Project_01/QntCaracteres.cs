namespace Project_01;

public class QntCaracteres
{
   public int Contar(string texto)
   {
      int contador = 0;
      foreach ( var letra in texto)
      {
         if (letra != ' ')
            contador++;
      }
      return contador;
   }
}