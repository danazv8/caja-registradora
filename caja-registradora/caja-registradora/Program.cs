const string nombreComercio = "KIOSKO EL RECREO";

Console.WriteLine($"=== {nombreComercio} ===");

Console.Write("Nombre del cajero:");

string cajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {cajero}. Caja abierta.");

Console.Write("Ingrese nombre del producto: ");

string nombreProducto = Console.ReadLine();

Console.Write("Ingrese precio del producto: ");

decimal precioProducto = decimal.Parse(Console.ReadLine());

Console.WriteLine($"El producto {nombreProducto} vale ${precioProducto}");



Console.ReadLine();

