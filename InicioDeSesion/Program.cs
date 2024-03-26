
const string UsuarioCorrecto = "usuario";
const string PassCorrecto = "123";

var sumar = 5 + 3;
var restar = 5 - 3;
var multiplicar = 5 * 3;
var dividir = 5 / 3;
var resto = 5 % 3;

Console.WriteLine("Iniciar Sesión" + "\n");
Console.WriteLine("Ingrese su nombre de usuario a continuación:" + "\n");
var usuarioIngresado = Console.ReadLine();
Console.Clear();

Console.WriteLine("Iniciar Sesión" + "\n");
Console.WriteLine("Ingrese su contraseña de usuario a continuación:" + "\n");
var passIngresado = Console.ReadLine();
Console.Clear();

if (usuarioIngresado == UsuarioCorrecto && passIngresado == PassCorrecto)
{
    Console.WriteLine("Bienvenido al sistema :)" + "\n");
    Console.WriteLine("Elija la operación que desea realizar:" + "\n");
    Console.WriteLine("1. Sumar 5 + 3" + "\n");
    Console.WriteLine("2. Restar 5 - 3" + "\n");
    Console.WriteLine("3. Multiplicar 5 * 3" + "\n");
    Console.WriteLine("4. Dividir 5 / 3" + "\n");
    Console.WriteLine("5. Resto 5 % 3" + "\n");

    var opcionSeleccionada = Console.ReadLine();

    switch (opcionSeleccionada)
    {
        case "1":
            Console.WriteLine("\n" + "Elegiste la opción de Sumar y el resultado de 5 + 3 es:" + "\n" + "\n" + sumar);
            Console.ReadKey();
            break;

        case "2":
            Console.WriteLine("\n" + "Elegiste la opción de Restar y el resultado de 5 - 3 es:" + "\n" + "\n" + restar);
            Console.ReadKey();
            break;

        case "3":
            Console.WriteLine("\n" + "Elegiste la opción de Multiplicar y el resultado de 5 * 3 es:" + "\n" + "\n" + multiplicar);
            Console.ReadKey();
            break;

        case "4":
            Console.WriteLine("\n" + "Elegiste la opción de Dividir y el resultado de 5 / 3 es:" + "\n" + "\n" + dividir);
            Console.ReadKey();
            break;

        case "5":
            Console.WriteLine("\n" + "Elegiste la opción de Dividir y el resultado de 5 / 3 es:" + "\n" + "\n" + resto);
            Console.ReadKey();
            break;


    }

}
else
{
    Console.WriteLine("Acceso Denegado :(");
}
