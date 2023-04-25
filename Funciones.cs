public static class Funciones
{
    public static string IngresarString(string txt)
    {
        string devolver;
        Console.WriteLine(txt);
        devolver = Console.ReadLine();
        return devolver;
    }

    public static int IngresarInt(string txt)
    {
        int devolver;
        Console.WriteLine(txt);
        devolver = int.Parse(Console.ReadLine());
        return devolver;
    }

    public static double IngresarDouble(string txt)
    {
        double devolver;
        Console.WriteLine(txt);
        devolver = double.Parse(Console.ReadLine());
        return devolver;
    }

    public static char IngresarChar(string txt)
    {
        char devolver;
        Console.WriteLine(txt);
        devolver = char.Parse(Console.ReadLine());
        return devolver;
    }

    public static DateTime IngresarDateTime(string txt)
    {
        DateTime devolver = new DateTime();
        string a = IngresarString(txt);
        while(!(DateTime.TryParse(a, out devolver)))
        {
            a = IngresarString(txt);
        }
        return devolver;
    }
    
    public static int GenerarRandom(int desde, int hasta)
        {
            int devolver;

            Random r = new Random();
            devolver = r.Next(desde, hasta + 1);

            return devolver;
        }

    public static int IngresarIntEntre(string txt, int min, int max)
    {
        int devolver;
        do{
        Console.WriteLine(txt);
        devolver = int.Parse(Console.ReadLine());
        }while(devolver<min||devolver>max);
        return devolver;
    }

     public static int BuscarPosIngreso(int buscado, int[] coso, int TOPE)
        {
            int posEncontarada = -1;
            int i = 0;
            while (i < TOPE && posEncontarada == -1)
            {
                if (buscado == coso[i])
                {
                    posEncontarada = i;
                }
                else { i++; }
            }
            return posEncontarada;
        }

    
}

