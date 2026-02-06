namespace Project_01;

public class PlacaValida
{
    public bool Verificar(string placa)
    {
        if (placa.Length != 7)
        {
            return false;
        }

        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
            {
                return false;
            }
        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placa[i]))
            {
                return false;
            }
        }
        return true;
    }
}