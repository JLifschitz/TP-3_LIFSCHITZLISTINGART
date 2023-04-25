using System.Collections.Generic;
 List<string> estadisticas = new List<string>();
const int ENTRADA_1=15000, ENTRADA_2=30000, ENTRADA_3=10000, ENTRADA_4=40000;
int menu, nuevoId, dni, tipo, abono = 0, id;
string nombre, apellido;
do{
menu=Funciones.IngresarInt("Ingrese 1 para una nueva inscripción, 2 para obtener estadisticas, 3 para buscar cliente, 4 para cambiar entrada de un cliente y 5 para finalizar");
    switch(menu)
    {
        case 1:
            dni = Funciones.IngresarInt("Ingrese su DNI");
            nombre = Funciones.IngresarString("Ingrese su nombre");
            apellido = Funciones.IngresarString("Ingrese su apellido");
            do{
                tipo = Funciones.IngresarInt("Ingrese el tipo de entrada");
            }while(tipo > 5 && tipo < 0);
            abono = CalcularAbono(ENTRADA_1, ENTRADA_2, ENTRADA_3, ENTRADA_4, tipo);
            Cliente nuevoCliente = new Cliente(dni, nombre, apellido, tipo, abono);
            id = Ticketera.AgregarCliente(nuevoCliente);

            Console.WriteLine("Su ID es: " + id);
        break;

        case 2:
            estadisticas = Ticketera.Estadisticas();
            foreach(string i in estadisticas) Console.WriteLine(i);
        break;

        case 3:
        id = Funciones.IngresarInt("Ingrese el id de una persona para buscar sus datos");
        nuevoCliente = Ticketera.BuscarCliente(id);
        Console.WriteLine("DNI: " + nuevoCliente.DNI);
        Console.WriteLine("NOMBRE : " + nuevoCliente.Nombre);
        Console.WriteLine("APELLIDO: " + nuevoCliente.Apellido);
        Console.WriteLine("TIPO ENTRADA: " + nuevoCliente.TipoEntrada);
        Console.WriteLine("ABONO: " + nuevoCliente.TotalAbonado);
        break;

        case 4:
            id = Funciones.IngresarInt("Ingrese el id de una persona para cambiar su entrada");
            do{
                tipo = Funciones.IngresarInt("Ingrese el tipo de entrada al que quiere cambiar");
            }while(tipo > 5 && tipo < 0);
            abono = CalcularAbono(ENTRADA_1, ENTRADA_2, ENTRADA_3, ENTRADA_4, tipo);
            if(Ticketera.CambiarEntrada(id, tipo, abono)) Console.WriteLine("Su entrada a sido cambiada con exito");
            else Console.WriteLine("No se pudo cambiar la entrada");
        break;
    }
    Console.ReadLine();
    Console.Clear();
}while(menu != 5);


static int CalcularAbono(int entrada1, int entrada2, int entrada3, int entrada4, int tipo)
{
    int devolver;
    
    if(tipo == 1) devolver = ENTRADA_1;
            else if (tipo == 2) devolver = ENTRADA_2;
            else if (tipo == 3) devolver = ENTRADA_3;
            else devolver = ENTRADA_4;
    return devolver;
}