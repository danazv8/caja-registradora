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
Console.WriteLine($"El total es: ${total}");


const decimal descuento10 = 0.10m;
const decimal descuento5 = 0.05m;

decimal descuento = 0;

if (total > 50000)
{
    descuento = total * descuento10;

}
else if (total > 20000)
{
    descuento = total * descuento5;
}

decimal totalConDescuento = total - descuento;


Console.WriteLine($"El subtotal es de: ${total}"); 
Console.WriteLine($"El descuento es de: ${descuento}");
Console.WriteLine($"El total con descuento aplicado: ${totalConDescuento}");


const decimal descuentoEf = 0.10m;
const decimal recargoCredito = 0.15m;

int medioDePago;

do
{
    Console.WriteLine();
    Console.WriteLine("Medio de pago: ");
    Console.WriteLine("1. Efectivo");
    Console.WriteLine("2. Debito");
    Console.WriteLine("3. Credito");
    Console.Write("Opcion: ");

    medioDePago = int.Parse(Console.ReadLine() ?? "0");

    switch (medioDePago)
    {
        case 1:
            decimal descuentoEfMonto = totalConDescuento * descuentoEf;
            decimal totalEf = totalConDescuento - descuentoEfMonto;
            Console.WriteLine($"Pago en efectivo con 10% de descuento.");
            Console.WriteLine($"Total final: {totalEf}");
            break;

        case 2:
            Console.WriteLine("Pago con debito: sin cambios.");
            Console.WriteLine($"Total final: {totalConDescuento}");
            break;

        case 3:
            decimal recargoCreditoMonto = totalConDescuento * recargoCredito;
            decimal totalCredito = totalConDescuento + recargoCreditoMonto;

            Console.WriteLine("Pago con credito: 15% de recargo.");
            Console.WriteLine($"Total final: {totalCredito}");
            break;

        default:
            Console.WriteLine("Opcion incorrecta. Ingrese 1, 2 o 3.");
            break;
    }
}
while (medioDePago < 1 || medioDePago > 3);  


Console.ReadLine();

