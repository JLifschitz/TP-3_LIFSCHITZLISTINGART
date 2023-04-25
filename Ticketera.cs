using System.Collections.Generic;
public static class Ticketera
{
    private static Dictionary<int, Cliente> DicClientes = new Dictionary<int, Cliente>();
    private static int UltimoId = 0;
    
    public static int DevolverUltimoId()
    {
        return UltimoId;
    }

    public static int AgregarCliente(Cliente cliente)
    {
        UltimoId++;
        DicClientes.Add(UltimoId, cliente);
        return UltimoId;
    }

    public static Cliente BuscarCliente(int id)
    {
        if(DicClientes.ContainsKey(id))
        {
            return DicClientes[id];
        }
        else return null;
    }

    public static bool CambiarEntrada(int id, int tipo, int total)
    {
        if(DicClientes.ContainsKey(id) && total > DicClientes[id].TotalAbonado)
        {
            DicClientes[id].TipoEntrada = tipo;
            DicClientes[id].TotalAbonado = total;
            return true;
        }
        else return false;
    }

    public static List<string> Estadisticas()
    {
        List<string> devolver = new List<string> ();
        int cont1=0, cont2=0, cont3=0, cont4=0, acum1=0, acum2=0,acum3=0,acum4=0;
        foreach(int i in DicClientes.Keys)
        {
            switch(DicClientes[i].TipoEntrada)
            {
                case 1:
                cont1++;
                acum1 += DicClientes[i].TotalAbonado;
                break;
                case 2:
                cont2++;
                 acum2 += DicClientes[i].TotalAbonado;
                break;
                case 3:
                cont3++;
                 acum3 += DicClientes[i].TotalAbonado;
                break;
                case 4:
                cont4++;
                 acum4 += DicClientes[i].TotalAbonado;
                break;
            }
        }
        devolver.Add("Hubo " + DicClientes.Count + " clientes");
        devolver.Add("Tipo 1: " + 100*cont1/DicClientes.Count + "%");
        devolver.Add("Tipo 2: " + 100*cont2/DicClientes.Count + "%");
        devolver.Add("Tipo 3: " + 100*cont3/DicClientes.Count + "%");
        devolver.Add("Tipo 4: " + 100*cont4/DicClientes.Count + "%");
        devolver.Add("Recaudacion tipo 1: " + acum1);
        devolver.Add("Recaudacion tipo 2: " + acum2);
        devolver.Add("Recaudacion tipo 3: " + acum3);
        devolver.Add("Recaudacion tipo 4: " + acum4);
        devolver.Add("Recaudacion total: " + (acum1 + acum2 + acum3 + acum4));

        return devolver;
    }
}