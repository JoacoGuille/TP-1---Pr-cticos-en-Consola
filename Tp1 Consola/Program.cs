using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== ACT TP 1 ===");
            Console.WriteLine("1: Sumar dos valores");
            Console.WriteLine("2: Contar los números que hay entre dos");
            Console.WriteLine("3: Perímetro de un triángulo");
            Console.WriteLine("4: Área de un cuadrado");
            Console.WriteLine("5: Área de un rectángulo");
            Console.WriteLine("6: Sacar diámetro desde la circunferencia");
            Console.WriteLine("7: Cuántos bits hay en X KB");
            Console.WriteLine("8: Factorial de 6");
            Console.WriteLine("9: Unir dos frases");
            Console.WriteLine("10: Mover la mitad de la frase al final");
            Console.WriteLine("11: Contar letras de una frase");
            Console.WriteLine("12: Fecha y hora actual");
            Console.WriteLine("13: Mostrar fecha en formato AA/AA/MMDD");
            Console.WriteLine("14: Diferencia de días entre dos fechas");
            Console.WriteLine("15: Cuántos días faltan para el 25/12/2020");
            Console.WriteLine("0: Salir");
            Console.Write("\nElegí una opción: ");

            string inputOpcion = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(inputOpcion) || !int.TryParse(inputOpcion, out opcion))
            {
                Console.Write("Eso no es un número válido. Probá otra vez: ");
                inputOpcion = Console.ReadLine();
            }

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    int num1 = PedirInt("Meté el primer número: ");
                    int num2 = PedirInt("Meté el segundo número: ");
                    Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
                    break;

                case 2:
                    int A = PedirInt("Número A: ");
                    int B = PedirInt("Número B: ");
                    Console.WriteLine($"Entre {A} y {B} hay {Math.Abs(B - A) - 1} números");
                    break;

                case 3:
                    int l1 = PedirInt("Lado 1: ");
                    int l2 = PedirInt("Lado 2: ");
                    int l3 = PedirInt("Lado 3: ");
                    Console.WriteLine($"El perímetro del triángulo es: {l1 + l2 + l3}");
                    break;

                case 4:
                    int lado = PedirInt("Lado del cuadrado: ");
                    Console.WriteLine($"El área del cuadrado es: {lado * lado}");
                    break;

                case 5:
                    int baseR = PedirInt("Base del rectángulo: ");
                    int alturaR = PedirInt("Altura del rectángulo: ");
                    Console.WriteLine($"El área del rectángulo es: {baseR * alturaR}");
                    break;

                case 6:
                    double circ = PedirDouble("Circunferencia: ");
                    Console.WriteLine($"El diámetro es: {circ / Math.PI}");
                    break;

                case 7:
                    int kb = PedirInt("Cuántos KB querés convertir: ");
                    long bits = kb * 1024L * 8L;
                    Console.WriteLine($"{kb} KB son {bits} bits");
                    break;

                case 8:
                    int f = 1;
                    for (int i = 1; i <= 6; i++) f *= i;
                    Console.WriteLine($"El factorial de 6 es: {f}");
                    break;

                case 9:
                    Console.Write("Escribí la primera frase: ");
                    string f1 = Console.ReadLine();
                    Console.Write("Ahora la segunda frase: ");
                    string f2 = Console.ReadLine();
                    Console.WriteLine($"Juntando las frases queda: {f1 + f2}");
                    break;

                case 10:
                    Console.Write("Meté una frase: ");
                    string frase = Console.ReadLine();
                    int mitad = frase.Length / 2;
                    string fraseMovida = frase.Substring(mitad) + frase.Substring(0, mitad);
                    Console.WriteLine($"Resultado: {fraseMovida}");
                    break;

                case 11:
                    Console.Write("Escribí algo: ");
                    string txt = Console.ReadLine();
                    Console.WriteLine($"Tu texto tiene {txt.Length} caracteres");
                    break;

                case 12:
                    Console.WriteLine($"La fecha y hora actual es: {DateTime.Now}");
                    break;

                case 13:
                    DateTime fecha = PedirFecha("Meté la fecha (dd/mm/aaaa): ");
                    Console.WriteLine($"Formato AAAAMMDD: {fecha:yyyyMMdd}");
                    break;

                case 14:
                    DateTime f1Fecha = PedirFecha("Fecha 1 (dd/mm/aaaa): ");
                    DateTime f2Fecha = PedirFecha("Fecha 2 (dd/mm/aaaa): ");
                    Console.WriteLine($"La diferencia es de {Math.Abs((f1Fecha - f2Fecha).Days)} días");
                    break;

                case 15:
                    DateTime navidad = new DateTime(2020, 12, 25);
                    int dias = (navidad - DateTime.Now).Days;
                    if (dias < 0)
                        Console.WriteLine("Esa fecha ya pasó!");
                    else
                        Console.WriteLine($"Faltan {dias} días para el 25/12/2020");
                    break;

                case 0:
                    Console.WriteLine("Chau, nos vemos!");
                    break;

                default:
                    Console.WriteLine("Esa opción no existe, probá otra.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresioná Enter para seguir...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }

    static int PedirInt(string mensaje)
    {
        int valor;
        string input;
        do
        {
            Console.Write(mensaje);
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out valor)) break;
            Console.WriteLine("Eso no es un número válido, probá de nuevo.");
        } while (true);
        return valor;
    }

    static double PedirDouble(string mensaje)
    {
        double valor;
        string input;
        do
        {
            Console.Write(mensaje);
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && double.TryParse(input, out valor)) break;
            Console.WriteLine("Eso no es un número válido, probá de nuevo.");
        } while (true);
        return valor;
    }

    static DateTime PedirFecha(string mensaje)
    {
        DateTime valor;
        string input;
        do
        {
            Console.Write(mensaje);
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && DateTime.TryParse(input, out valor)) break;
            Console.WriteLine("Fecha inválida, probá otra vez (dd/mm/aaaa).");
        } while (true);
        return valor;
    }
}
