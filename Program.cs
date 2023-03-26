using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int op = 0;

        do
        {
            Console.WriteLine("Menú de opciones");
            Console.WriteLine("1. Cálculo de Aumento Salarial ...");
            Console.WriteLine("2. Cobros por llamadas... ");
            Console.WriteLine("3. Facturación Restaurante... ");
            Console.WriteLine("4. Salir ...");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:

                    double salario = 0, t1 = 0, t2 = 0;

                    Console.WriteLine("Ingrese el salario del empleado:");
                    salario = float.Parse(Console.ReadLine());
                    if (salario >= 0)
                    {
                        if (salario >= 0 && salario <= 2999)
                        {

                            t1 = salario * 0.15;
                            t2 = t1 + salario;

                            Console.WriteLine("El salario es de: " + salario);
                            Console.WriteLine("El incremento es de: " + t1);
                            Console.WriteLine("El salario mas incremento es de: " + t2);
                        }
                        else if (salario >= 3000 && salario <= 5000)
                        {
                            t1 = salario * 0.10;
                            t2 = t1 + salario;

                            Console.WriteLine("El salario es de: " + salario);
                            Console.WriteLine("El incremento es de: " + t1);
                            Console.WriteLine("El salario mas incremento es de: " + t2);
                        }
                        else if (salario > 5000)
                        {
                            t1 = salario * 0.075;
                            t2 = t1 + salario;

                            Console.WriteLine("El salario es de: " + salario);
                            Console.WriteLine("El incremento es de: " + t1);
                            Console.WriteLine("El salario mas incremento es de: " + t2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opcion Incorrecta ... ");
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    double inter = 2, interextra = 3, nacionalex = 2, localextra = 1, opcion = 0;
                    double nacional = 1.5, local = 0.5;

                    Console.WriteLine("Cobro de Llamadas");
                    Console.WriteLine("1. Internacionales");
                    Console.WriteLine("2. Nacionales");
                    Console.WriteLine("3. Locales");
                    Console.WriteLine("4. Salir");

                    Console.WriteLine("Que llamadas desea cobrar");
                    opcion = int.Parse(Console.ReadLine());

                    if (opcion >= 0)
                    {
                        switch (opcion)
                        {
                            case 1:
                                double minutos = 0, cobro = 0, pagar = 0;
                                Console.WriteLine("Cobro de llamadas Internacionales");
                                Console.WriteLine("¿Cuantos minutos desea cobrar?");
                                minutos = double.Parse(Console.ReadLine());

                                if (minutos >= 0)
                                {
                                    if (minutos == 1)
                                    {
                                        Console.WriteLine("El total a pagar es: Q." + inter);
                                    }
                                    else if (minutos >= 2)
                                    {
                                        cobro = minutos - 1;
                                        pagar = cobro * interextra;
                                        Console.WriteLine("El total a pagar con minutos extra es: " + (pagar + inter));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Opcion Incorrecta...");
                                }
                                break;
                            case 2:

                                double minutosn = 0, cobron = 0, pagarn = 0;
                                Console.WriteLine("Cobro de llamadas Nacionales");
                                Console.WriteLine("¿Cuantos minutos desea cobrar?");
                                minutosn = double.Parse(Console.ReadLine());

                                if (minutosn >= 0)
                                {
                                    if (minutosn == 1)
                                    {
                                        Console.WriteLine("El total a pagar es: Q." + nacional);
                                    }
                                    else if (minutosn >= 2)
                                    {
                                        cobron = minutosn - 1;
                                        pagarn = cobron * nacionalex;
                                        Console.WriteLine("El total a pagar con minutos extra es: " + (pagarn + nacional));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Opcion Incorrecta...");
                                }
                                Console.ReadKey();
                                break;

                            case 3:

                                double minutosl = 0, cobrol = 0, pagarl = 0;
                                Console.WriteLine("Cobro de llamadas Loles");
                                Console.WriteLine("¿Cuantos minutos desea cobrar?");
                                minutosl = double.Parse(Console.ReadLine());
                                if (minutosl >= 0)
                                {
                                    if (minutosl == 1)
                                    {
                                        Console.WriteLine("El total a pagar es: Q." + local);
                                    }
                                    else if (minutosl >= 2)
                                    {
                                        cobrol = minutosl - 1;
                                        pagarl = cobrol * localextra;
                                        Console.WriteLine("El total a pagar con minutos extra es: " + (pagarl + local));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Opcion Incorrecta...");
                                }
                                Console.ReadKey();

                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opcion Incorrecta...");
                        Console.ReadKey();
                    }

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    int op3 = 0, precio = 0, op2 = 0;
                    double tot1 = 0, desc = 0, tot2 = 0, totor = 0;
                    string name = "", opcioncom = "", nit = "";

                    Console.Clear();

                    Console.WriteLine("Ingrese su nombre");
                    name = Console.ReadLine();
                    Console.WriteLine("Ingrese su NIT");
                    nit = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("MENU RESTAURANTES");
                    Console.WriteLine("1. Desayuno");
                    Console.WriteLine("2. Almuerzo");
                    Console.WriteLine("3. Cenas");
                    Console.WriteLine("4. Bebidas");
                    Console.WriteLine("5. Salir");
                    Console.WriteLine("Elija la opcion que desea");
                    op3 = int.Parse(Console.ReadLine());

                    switch (op3)
                    {
                        case 1:
                            precio = (30);
                            opcioncom = "desayunos";
                            break;
                        case 2:
                            precio = (75);
                            opcioncom = "almuerzos";
                            break;
                        case 3:
                            precio = (25);
                            opcioncom = "cenas";
                            break;
                        case 4:
                            precio = (5);
                            opcioncom = "bebidas";
                            break;
                        case 5:
                            break;

                    }
                    Console.WriteLine("Cuantos ordenes desea ordenar?");
                    op2 = int.Parse(Console.ReadLine());

                    if (op2 >= 0)
                    {
                        totor = (double)(precio * op2);

                        if (totor >= 1 && totor <= 25)
                        {
                            desc = (double)(totor * 0.10);
                            tot2 = (totor - desc);
                        }
                        else if (totor >= 26 && totor <= 50)
                        {
                            desc = (double)(totor * 0.12);
                            tot2 = (totor - desc);

                        }
                        else if (totor >= 51 && totor <= 75)
                        {
                            desc = (double)(totor * 0.15);
                            tot2 = (totor - desc);
                        }
                        else if (totor >= 76 && totor <= 100)
                        {
                            desc = (double)(totor * 0.17);
                            tot2 = (totor - desc);
                        }
                        else if (totor > 100)
                        {
                            desc = (double)(totor * 0.20);
                            tot2 = (totor - desc);


                        }

                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("                 MENÚ DEL CLIENTE               ");
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("NOMBRE:\t" + name);
                        Console.WriteLine("NIT:\t" + nit);
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine(+op2 + " " + opcioncom + " de Q" + precio);
                        Console.WriteLine("             Monto gastado: Q" + totor);
                        Console.WriteLine("             Descuento: Q" + desc);
                        Console.WriteLine("             Monto a pagar: Q" + tot2);
                        Console.WriteLine("------------------------------------------------");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Opcion Incorrecta");
                        Console.ReadKey();
                    }

                    
                    break;

                case 4:
                    Console.WriteLine("Salir");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opcion Incorrecta");
                    Console.ReadKey();
                    break;
            }
        } while (op != 4);

    }
}