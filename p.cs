using System;

public class Class1
{
	public Class1()
	{
        string[] usuarios = { "usuario1", "usuario2", "usuario3" };
        string[] contrasenas = { "pass1", "pass2", "pass3" };

        Console.Write("Ingresa el nombre de usuario: ");
        string usuarioIngresado = Console.ReadLine();

        Console.Write("Ingresa la contraseña: ");
        string contrasenaIngresada = Console.ReadLine();

        if (ValidarCredenciales(usuarioIngresado, contrasenaIngresada, usuarios, contrasenas))
        {
            Console.WriteLine("Acceso concedido. ¡Bienvenido!");
        }
        else
        {
            Console.WriteLine("Credenciales incorrectas. Acceso denegado.");
        }
    }

    static bool ValidarCredenciales(string usuario, string contrasena, string[] usuarios, string[] contrasenas)
    {
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuario && contrasenas[i] == contrasena)
            {
                return true;
            }
        }
        return false;
    }
}
