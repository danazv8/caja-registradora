const string NombreComercio = "KIOSKO EL RECREO";

Console.WriteLine($"=== {NombreComercio} ===");

Console.Write("Nombre del cajero:");

string cajero = Console.ReadLine() ?? "";

Console.WriteLine($"Bienvenida, {cajero}. Caja abierta.");


decimal total = 0;
int cantidadProductos = 0;

int opcion;
do
{
    Console.WriteLine();
    Console.WriteLine("¿Que desea hacer?");
    Console.WriteLine("1. Cargar producto");
    Console.WriteLine("2. Cerrar venta");
    Console.Write("Opcion: ");

    opcion = int.Parse(Console.ReadLine() ?? "0");

    switch (opcion)
    {
        case 1:
            Console.Write("Nombre del producto: ");
            string producto = Console.ReadLine() ?? "";

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine() ?? "0");

            total += precio;
            cantidadProductos++;

            Console.WriteLine($"Producto cargado: {producto} - ${precio}");
            break;

        case 2:
            Console.Write("Venta cerrada.");
            break;

        default:
            Console.WriteLine("Opcion incorrecta");
            break;

    }
}
while (opcion != 2);

Console.WriteLine();
Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
Console.WriteLine($"El total es: {total}");



Console.ReadLine();

