using System.ComponentModel;
using System.ComponentModel.Design;

int opp, op1, op2;
Console.WriteLine("Seleccione una opción: \n1.Estructuras condiconlaes \n2.Ejercicios con Switch");
opp = int.Parse(Console.ReadLine());

switch (opp)
{
    case 1:
        
            do
            {
                Console.WriteLine("Seleccione una opción: \n1.Calcular el mayor de tres números. \n2.Validar edad para ingresar a un Club. \n3.Calcular el Precio Final de un Producto. \n4.Validar usuario y contraseña. \n5.Determinar si un número es Par o Impar. \n6.Mostrar un Mensaje de Aprobación o Rechazo de Préstamo. \n7.Calcular el Área de una Figura Geométrica. \n8.Salir ");
                op1 = int.Parse(Console.ReadLine());

                switch (op1)
                {
                    case 1:
                        try
                        {
                            Console.Write("Ingrese el primer número: ");
                            double n1 = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese el segundo número: ");
                            double n2 = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese el tercer número: ");
                            double n3 = double.Parse(Console.ReadLine());

                            if (n1 >= n2 && n1 >= n3)
                                Console.WriteLine(n1 + " es el número mayor.");
                            else if (n2 > n3)
                                Console.WriteLine(n2 + " es el número mayor.");
                            else
                                Console.WriteLine(n3 + " es el número mayor.");
                        }
                        catch (Exception ex)
                        { Console.WriteLine("Parece que no ingresaste un valor númerico."); }
                        break;

                    case 2:
                        try
                        {
                            Console.Write("Ingrese su edad, porfavor: ");
                            int años = int.Parse(Console.ReadLine());

                            if (años >= 18)
                                Console.WriteLine("Eres mayor de edad. Puedes ingresar al Club.");
                            else
                                Console.WriteLine("Eres menor de edad. No puedes ingresar al Club.");
                        }
                        catch (Exception ex)
                        { Console.WriteLine("No ingresaste un valor valido para tu edad."); }
                        break;

                    case 3:
                        try
                        {
                            Console.Write("Ingrese el valor de su compra: ");
                            double precio = double.Parse(Console.ReadLine());

                            double desc = precio / 10;
                            double liq = precio - desc;
                            if (precio >= 100)
                                Console.Write("Su compra ha recibido un descuento del 10%. El precio final es de: " + liq);
                            else
                                Console.WriteLine("Su compra no ha recibido un descuento. El precio final es de: " + precio);
                        }
                        catch (Exception ex)
                        { Console.WriteLine("No ha ingresado un valor valido en su compra."); }
                        break;
                    case 4:
                        try
                        {
                            string[] user = { "Alan", "Josue", "Luna" };
                            string[] pass = { "123", "456", "789" };

                            Console.Write("Ingrese su usuario: ");
                            string userI = Console.ReadLine();

                            Console.Write("Ingrese la contraseña: ");
                            string passI = Console.ReadLine();

                            if (ValidarCredenciales(userI, passI, user, pass))
                                Console.WriteLine("Usario y Contraseñas correctas. Acceso Concedido.");

                            else
                                Console.WriteLine("Usuario o Contraseñas incorrectas. Acceso Denegado.");

                            static bool ValidarCredenciales(string userI, string passI, string[] user, string[] pass)
                            {
                                for (int i = 0; i < user.Length; i++)
                                {
                                    if (user[i] == userI && pass[i] == passI)
                                    {
                                        return true;
                                    }
                                }
                                return false;
                            }
                        }
                        catch (Exception ex)
                        { Console.WriteLine("Parece que ha ingresado caracteres invalidos en su usuario o contraseña."); }
                        break;

                    case 5:
                        try
                        {
                            Console.Write("Ingresa el número a evaluar ");
                            int n = Convert.ToInt32(Console.ReadLine());

                            if (n % 2 == 0)
                                Console.WriteLine("El número ingresado es Par.");
                            else
                                Console.WriteLine("El número ingresado es Impar.");

                        }
                        catch (Exception ex)
                        { Console.WriteLine("Ha ingresado un valor invalido."); }
                        break;

                    case 6:
                        try
                        {
                            Console.WriteLine("Ingrese su nombre: ");
                            string nomb = Console.ReadLine();
                            Console.WriteLine("Ingrese su edad: ");
                            int edad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el montón del prestamo a realizar: ");
                            double prest = Convert.ToDouble(Console.ReadLine());

                            if (edad >= 60 || prest < 5000)
                                Console.WriteLine("Su prestamo ha sido aprobado con exito.");
                            else
                                Console.WriteLine("Su prestamo excede los Q5,00 y no es mayor de 60 años");

                        }
                        catch (Exception ex)
                        { Console.WriteLine("Ha ingresado un caracter invalido en alguno de los campos."); }
                        break;

                    case 7:
                        try
                        {
                            Console.WriteLine("Seleccione la figura que desea calcular su area: \n1.Triángulo. \n2.Cuadrado. \n3.Circulo. ");
                            int op7 = int.Parse(Console.ReadLine());

                            switch (op7)
                            {
                                case 1:
                                    Console.WriteLine("Ingrese la base del triangulo: ");
                                    double bt = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Ingrese la altura del triangulo: ");
                                    double at = Convert.ToDouble(Console.ReadLine());

                                    double art = (bt * at) / 2;
                                    Console.WriteLine("El area del triangulo es de: " + art);
                                    break;
                                case 2:
                                    Console.WriteLine("Ingrese el largo de los lados del cuadrado: ");
                                    double cl = Convert.ToDouble(Console.ReadLine());

                                    double arc = cl * cl;
                                    Console.WriteLine("El area del cuadrado es de: " + arc);
                                    break;
                                case 3:
                                    Console.WriteLine("Ingrese el radio del circulo: ");
                                    double rc = Convert.ToDouble(Console.ReadLine());

                                    double ac = Math.PI * Math.Pow(rc, 2);
                                    Console.WriteLine("El area del circulo es de: " + rc);
                                    break;
                            }
                        }
                        catch (Exception ex)
                        { Console.WriteLine("Ha ingresado un caracter invalido en alguno de los campos."); }
                        break;

                    default:
                        Console.WriteLine("Ha ingresado una opción invalida. Seleccione una opción valida del menú");
                        break;

                }
            } while (op1 != 8);
            Console.WriteLine("Nos vemos");
     break;

    case 2:
            do
            {
                Console.WriteLine("Seleccione una opción: \n1.Convertir un número de netra a número. \n2.Mostrar el día de la semana a partir de un número. \n3.Calcular el importe a pagar por un servicio. \n4.Mostrar un mensaje de bienvenida en diferentes idiomas. \n5.Evaluar la calificación de un examen. \n6.Salir ");
                op2 = int.Parse(Console.ReadLine());

                switch (op2) 
                {
                    case 1:
                        Console.Write("Ingresa un número en letras del 1 al 5 ");
                        string ne = Console.ReadLine().ToLower(); 

                        int nd;
                        switch (ne)
                        {
                            case "uno":
                                nd = 1;
                                break;
                            case "dos":
                                nd = 2;
                                break;
                            case "tres":
                                nd = 3;
                                break;
                            case "cuatro":
                                nd = 4;
                                break;
                            case "cinco":
                                nd = 5;
                                break;
                            default:
                                Console.WriteLine("Ha escrito un número invalido vuelva intentarlo ");
                                break;}
                    break;

                    case 2:
                        Console.Write("Ingresa un número del 1 al 7: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        string ds;
                        switch (num)
                        {
                            case 1:
                                ds = "Lunes";
                                break;
                            case 2:
                                ds = "Martes";
                                break;
                            case 3:
                                ds = "Miercoles";
                                break;
                            case 4:
                                ds = "Jueves";
                                break;
                            case 5:
                                ds = "Viernes";
                                break;
                            case 6:
                                ds = "Sabado";
                                break;
                            case 7:
                                ds = "Domingo ";
                                break;
                            default:
                                Console.WriteLine("Ha ingreado un numero invalido");
                                break;
                        }
                        break;
                    case 3:
                            Console.WriteLine("Selecciones una opción: \n1.Lavado de auto \n2.Cambio de aceite \n3.Revisión mecánica ");
                            int imp = Convert.ToInt32(Console.ReadLine());

                            switch (imp)
                            {
                            case 1:
                                Console.WriteLine("El importe a pagar es de Q50.");
                                break;
                            case 2:
                                Console.WriteLine("El importe a pagar es de Q80.");
                                break;
                            case 3:
                                Console.WriteLine("El importe a pagar es de Q100.");
                                break;
                            default:
                                Console.WriteLine("Ha seleccionado una opcion invalida");
                                break;
                        }
                        break;
                    case 4:
                            Console.WriteLine("Selecciones el idioma de su preferencia: \n1.Español \n2.Inglés \n3.Francés ");
                            int idiom = Convert.ToInt32(Console.ReadLine());

                            switch (idiom)
                            {
                            case 1:
                                Console.WriteLine("¡Buen dia, sea Bienvenid@!");
                                break;
                            case 2:
                                Console.WriteLine("Good morning, Welcome!");
                                break;
                            case 3:
                                Console.WriteLine("Bonjour, Bienvenue!");
                                break;
                            }
                        break;
                    case 5:
                            Console.WriteLine("Ingrese la calificación final de su examen: ");
                            double exam = Convert.ToDouble(Console.ReadLine());

                            switch (exam) 
                            { 
                            case double e when (e>=90 && e<=100):
                                Console.WriteLine("Su nota es Sobresaliente.");
                            break;
                            case double e when (e >= 80 && e <= 89):
                                Console.WriteLine("Su nota es Notable.");
                            break;
                            case double e when (e >= 61 && e <= 79):
                                Console.WriteLine("Su nota es Aprovatoria.");
                            break;
                            case double e when (e <= 60):
                                Console.WriteLine("Su nota es insuficiente.");
                            break;
                    }
                    break;

                }

            } while (op2 != 6);
            Console.WriteLine("Nos vemos");
        break;
    }
