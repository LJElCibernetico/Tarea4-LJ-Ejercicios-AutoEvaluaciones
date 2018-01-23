using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Tarea4
    {
        public enum Neumaticos { Para_Coche, Para_Furgoneta, Para_4X4 };
        public enum Extrellas { O, B, A, G, F, K, M };


        static void Main(string[] args)
        {
            Tarea4 t4 = new Tarea4();
            ProductosMercado PM;
            CuentaBancaria CB;
            Dueño D;
            ConsoleKeyInfo menu;

            do
            {
                Console.Clear();
                Console.Write("\t\t\t\t******\n");
                Console.Write("\t\t\t\t*Menú*\n");
                Console.Write("\t\t\t\t******\n");
                Console.WriteLine("[A] - Ejercicio 7.1\t");
                Console.WriteLine("[B] - Ejercicio 7.2\t");
                Console.WriteLine("[C] - Ejercicio 7.3\t");
                Console.WriteLine("[D] - Ejercicio 7.4\t");
                Console.WriteLine("[E] - Ejercicio 7.5\t");
                Console.WriteLine("[F] - Ejercicio 8.1\t");
                Console.WriteLine("[G] - Ejercicio 8.2\t");
                Console.WriteLine("[H] - Ejercicio 8.3\t");
                Console.WriteLine("[I] - Ejercicio 8.4\t");
                Console.WriteLine("[J] - Ejercicio 8.5\t");
                Console.WriteLine("[K] - Ejercicio 9.1\t");
                Console.WriteLine("[L] - Ejercicio 9.2\t");
                Console.WriteLine("[M] - Ejercicio 9.3\t");
                Console.WriteLine("[N] - Ejercicio 9.4\t");
                Console.WriteLine("[O] - Ejercicio 9.5\t");
                Console.WriteLine("[P] - Ejercicio 12.2\t");
                Console.WriteLine("[Q] - Ejercicio 12.3\t");
                Console.WriteLine("[Esc] Salir\t\n\n");
                Console.WriteLine("Seleccione una opcion");
                menu = Console.ReadKey(true);

                switch (menu.Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        t4.Ejercicio7_1();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        Console.Clear();
                        t4.Ejercicio7_2();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.C:
                        Console.Clear();
                        t4.Ejercicio7_3();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D:
                        Console.Clear();
                        t4.Ejercicio7_4();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.E:
                        Console.Clear();
                        t4.Ejercicio7_5();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.F:
                        Console.Clear();
                        t4.Ejercicio8_1();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.G:
                        Console.Clear();
                        t4.Ejercicio8_2();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.H:
                        Console.Clear();
                        t4.Ejercicio8_3();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.I:
                        Console.Clear();
                        t4.Ejercicio8_4();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.J:
                        Console.Clear();
                        t4.Ejercicio8_5();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.K:
                        Console.Clear();
                        PM.CodigoDeBarras = 00092;
                        PM.NombreProducto = "PAN";
                        PM.PrecioProducto = 50;
                        Console.WriteLine("Codigo de Barras: " + PM.CodigoDeBarras + "\nNombre del Producto: "
                                          + PM.NombreProducto + "\nPrecio del Producto: " + PM.PrecioProducto);
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.L:
                        Console.Clear();
                        CB.NumeroCuenta = "0904568542";
                        CB.NombreCliente = "LJ";
                        CB.Dinero = 1000000;
                        Console.WriteLine("Numero de Cuenta: " + CB.NumeroCuenta + "\nNombre del Cliente: "
                                         + CB.NombreCliente + "\nMonto Almacenado: " + CB.Dinero);
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.M:
                        Console.Clear();
                        D.NombreDueño = "LJ";
                        D.EdadDueño = 19;
                        D.Perro.NombreMascota = "Scooby";
                        D.Perro.TipoMascota = "Chiguagua";
                        D.Perro.EdadMascota = 10;
                        Console.WriteLine("Nombre del Dueño: " + D.NombreDueño + "\nEdad del Dueño: "
                                        + D.EdadDueño + "\nNombre de la Mascota: " + D.Perro.NombreMascota
                                        + "\nTipo de Mascota: " + D.Perro.TipoMascota + "\nEdad de La Mascota: "
                                        + D.Perro.TipoMascota);
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.N:
                        Console.Clear();
                        Console.WriteLine("Tipos de Neumaticos: \n\n");
                        Console.WriteLine(Neumaticos.Para_4X4.ToString());
                        Console.WriteLine(Neumaticos.Para_Coche.ToString());
                        Console.WriteLine(Neumaticos.Para_Furgoneta.ToString());
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.O:
                        Console.Clear();
                        Console.WriteLine("Tipos de Extrellas: \n\n");
                        Console.WriteLine("*" + Extrellas.O.ToString() + "*");
                        Console.WriteLine("*" + Extrellas.B.ToString() + "*");
                        Console.WriteLine("*" + Extrellas.A.ToString() + "*");
                        Console.WriteLine("*" + Extrellas.G.ToString() + "*");
                        Console.WriteLine("*" + Extrellas.F.ToString() + "*");
                        Console.WriteLine("*" + Extrellas.K.ToString() + "*");
                        Console.WriteLine("*" + Extrellas.M.ToString() + "*");
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.P:
                        Console.Clear();
                        t4.Ejercicio12_2();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Q:
                        Console.Clear();
                        t4.Ejercicio12_3();
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("Gracias Por Corregir");
                        Console.WriteLine("\nPreciona una tecla para salir...");
                        Console.ReadKey();
                        break;
                }
            } while (menu.Key != ConsoleKey.Escape);
        }

        public struct ProductosMercado
        {
            public int CodigoDeBarras;
            public string NombreProducto;
            public int PrecioProducto;

            public ProductosMercado(int nCodigoDeBarras, string nNombreProducto, int nPrecioProducto)
            {
                CodigoDeBarras = nCodigoDeBarras;
                NombreProducto = nNombreProducto;
                PrecioProducto = nPrecioProducto;
            }
        }

        public struct CuentaBancaria
        {
            public string NombreCliente;
            public string NumeroCuenta;
            public int Dinero;

            public CuentaBancaria(string nNombreCliente, string nNumeroCuenta, int nDinero)
            {
                NombreCliente = nNombreCliente;
                NumeroCuenta = nNumeroCuenta;
                Dinero = nDinero;
            }
        }

        public struct Mascota
        {
            public string NombreMascota;
            public int EdadMascota;
            public string TipoMascota;

            public Mascota(string nNombreMascota, int nEdadMascota, string nTipoMascota)
            {
                NombreMascota = nNombreMascota;
                EdadMascota = nEdadMascota;
                TipoMascota = nTipoMascota;
            }
        }

        public struct Dueño
        {
            public string NombreDueño;
            public int EdadDueño;
            public Mascota Perro;

            public Dueño(string nNombreDueño, int nEdadDueño, string NM, int EM, string TM)
            {
                NombreDueño = nNombreDueño;
                EdadDueño = nEdadDueño;

                Perro = new Mascota(NM, EM, TM);
            }
        }

        struct GF
        {
            public DateTime fecha;
            public int gastos;
        };

        public void Ejercicio8_1()
        {
            ///Hacer un programa que le pida al usuario una cadena y muestre 
            ///cada una de las palabras de la cadena en una línea.
            Console.WriteLine("Digite una cadena: ");
            string encontrado = Console.ReadLine();
            string[] cadenas_separadas;
            cadenas_separadas = encontrado.Split(' ');
            Console.WriteLine("\nLas Palabras Que Contiene Esta Cadena Son: ");
            foreach (string cadena in cadenas_separadas)
            {
                Console.WriteLine(cadena);
            }
        }

        public void Ejercicio8_2()
        {
            ///Hacer un programa que le pida al usuario una cadena y la forma de justificarla.
            Console.WriteLine("Digite una cadena: ");
            string str = Console.ReadLine();

            string resultado = str.PadLeft(str.Length + 5, ' ');

            Console.WriteLine("La cadena justificada es: " + resultado);
        }

        public void Ejercicio8_3()
        {
            ///Hacer un programa que muestre la hora del día en formato AM / FM seguida del año, el día y el mes actual.
            DateTime thisDay = DateTime.Today;

            Console.WriteLine("The current date and time: {0: h:mm:ss}", DateTime.Now);
            Console.WriteLine("The current date and time: {0: HH:mm:ss}", DateTime.Now);
            Console.WriteLine("La fecha de hoy es: " + thisDay.ToString());
        }

        public void Ejercicio8_4()
        {
            ///Hacer un programa que calcule sumas y muestre los resultados negativos entre paréntesis.
            int n1, n2, r;
            Console.WriteLine("Digite un numero (Positivo o negativo): ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro numero (Positivo o negativo): ");
            n2 = int.Parse(Console.ReadLine());

            r = n1 + n2;

            Console.WriteLine("El resultado es: ");

            if (r < 0)
                Console.WriteLine("(" + r + ")");


            else
                Console.WriteLine(r);
        }

        public void Ejercicio8_5()
        {
            ///Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.
            string cad1 = " ", cad2 = " ", conct = " ";
            char ch = ' ';

            Console.WriteLine("Digite la primera cadena: ");
            cad1 = Console.ReadLine();
            Console.WriteLine("Digite la segunda cadena: ");
            cad2 = Console.ReadLine();

            conct = string.Concat(cad1, cad2);

            var chars = conct.ToCharArray();

            int[] arr = new int[chars.Length];

            for (int i = 0; i < chars.Length; ++i)
            {
                arr[i] = chars[i];
            }
            Array.Sort(arr);

            Console.WriteLine("Ordenadas en orden alfabetico serian: ");
            for (int k = 0; k < chars.Length; ++k)
            {
                ch = Convert.ToChar(arr[k]);
                Console.WriteLine(ch);
            }
        }

        public void Ejercicio7_1()
        {
            ArrayList calfs = new ArrayList();

            int est = 0, comp = 0;
            float calificacion = 0, min = 0, max = 0, promedio = 0;
            string st;

            Console.WriteLine("Ingrese la cantidad de estudiantes: ");
            est = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < est; ++j)
            {
                Console.WriteLine("Ingrese la calificacion del estudiante: ");
                calificacion = Convert.ToSingle(Console.ReadLine());
                calfs.Add(calificacion);

                st = calfs[j].ToString();
                comp = Convert.ToInt32(st);

                if (comp > max)
                {
                    max = comp;
                }

                if (j == 0)
                {
                    min = comp;
                }
                else if (j > 0 && comp < min)
                {
                    min = comp;
                }
                promedio += comp;
            }

            Console.WriteLine("La menor calificacion es: " + min);
            Console.WriteLine("La mayor calificacion es: " + max);
            Console.WriteLine("El promedio de las calificaciones es: " + promedio / est);
        }

        public void Ejercicio7_2()
        {
            Hashtable ht = new Hashtable();

            string pal, def;
            int op = 0;
            char opc = ' ';

            while (op != 3)
            {
                Console.Clear();
                Console.WriteLine("Elija una opcion:\n1-Insertar palabra.\n2-Buscar palabra\n3-Salir.");

                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Escriba la palabra: ");
                            pal = Console.ReadLine();

                            Console.WriteLine("Escriba su definicion: ");
                            def = Console.ReadLine();

                            ht.Add(pal, def);

                            Console.WriteLine("Desea agregar otra palabra? y | n: ");
                            opc = Convert.ToChar(Console.ReadLine());

                            if (opc == 'y' || opc == 'Y')
                            {
                                continue;
                            }
                            else if (opc == 'n' || opc == 'N')
                            {
                                break;
                            }

                        }

                        break;

                    case 2:
                        Console.Clear();

                        foreach (DictionaryEntry entry in ht)
                        {
                            Console.WriteLine("Palabra: " + entry.Key + " Definicion: " + entry.Value);
                        }
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void Ejercicio7_3()
        {
            Queue f = new Queue();
            string nombre;
            int cli, k = 0;

            Console.WriteLine("Digite la cantidad de clientes: ");
            cli = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < cli; ++j)
            {
                Console.WriteLine("Digite el nombre del cliente: ");
                nombre = Console.ReadLine();
                f.Enqueue(nombre);
            }

            foreach (int i in f)
            {
                Console.WriteLine(f + "Fue atendido de numero." + k);
                k++;
            }
        }

        public void Ejercicio7_4()
        {
            ArrayList gast = new ArrayList();
            GF gf = new GF();

            int an = 0, mes = 0, dia = 0, g = 0, sum = 0;
            char opc = ' ';

            while (true)
            {
                Console.WriteLine("Escriba la fecha, en formato anio, mes, dia: ");
                an = Convert.ToInt32(Console.ReadLine());
                mes = Convert.ToInt32(Console.ReadLine());
                dia = Convert.ToInt32(Console.ReadLine());

                gf.fecha = new DateTime(an, mes, dia);

                Console.WriteLine("Escriba el gasto: ");
                g = Convert.ToInt32(Console.ReadLine());

                gf.gastos = g;

                sum += gf.gastos;

                gast.Add(gf);

                Console.WriteLine("Desea agregar otra palabra? y | n: ");
                opc = Convert.ToChar(Console.ReadLine());

                if (opc == 'y' || opc == 'Y')
                {
                    continue;
                }
                else if (opc == 'n' || opc == 'N')
                {
                    break;
                }

            }
            Console.WriteLine("La suma es: " + sum);
        }

        public void Ejercicio7_5()
        {
            Hashtable ht = new Hashtable();

            int op = 0, num = 0;
            string nombre = " ";
            char opc = ' ';

            while (op != 3)
            {
                Console.Clear();
                Console.WriteLine("Elija una opcion:\n1-Insertar Contacto.\n2-Buscar Contacto\n3-Salir.");

                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Escriba el nombre: ");
                            nombre = Console.ReadLine();

                            Console.WriteLine("Escriba el numero: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            ht.Add(nombre, num);

                            Console.WriteLine("Desea agregar otro contacto? y | n: ");
                            opc = Convert.ToChar(Console.ReadLine());

                            if (opc == 'y' || opc == 'Y')
                            {
                                continue;
                            }
                            else if (opc == 'n' || opc == 'N')
                            {
                                break;
                            }

                        }

                        break;

                    case 2:
                        Console.Clear();

                        foreach (DictionaryEntry entry in ht)
                        {
                            Console.WriteLine("Nombre: " + entry.Key + " Numero: " + entry.Value);
                        }
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void Ejercicio12_2()
        {
            int op = 0, n = 0, cant = 0, sum = 0, num = 0;

            while (op != 3)
            {
                Console.Clear();
                Console.WriteLine("Elija una opcion:\n\n1-Numero par e impar.\n2-Promedio.\n3-Salir.");
                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ha entrado a la funcion de numeros pares e impares.");
                        Console.WriteLine("Ingrese un numero: ");
                        n = Convert.ToInt32(Console.ReadLine());

                        if (n % 2 == 0)
                        {
                            Console.WriteLine("El numero es par.");
                        }
                        else
                        {
                            Console.WriteLine("El numero es impar");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Ha salido se la funcion de numeros pares e impares");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese la cantidad de numeros: ");
                        cant = Convert.ToInt16(Console.ReadLine());

                        for (int i = 0; i < cant; ++i)
                        {
                            Console.WriteLine("Ingrese el numero: " + i);
                            num = Convert.ToInt16(Console.ReadLine());
                            sum += num;
                        }
                        Console.WriteLine("El promedio es: " + sum / cant);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Ha salido de la funcion del promedio.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        
        public void Ejercicio12_3()
        {
            Console.WriteLine("Excepciones de arreglos:\n1-IndexOutOfRangeException.\n3-ArgumentException.\n4-ArgumentOutOfRangeException.5-ArrayTypeMismatchException");
        }
    }
}

