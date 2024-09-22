using System;
using System.Collections.Generic;

class Estudiante
{
    // Propiedades, declaración de las variables del programa
    public string Nombre;
    private int Edad;
    public double Promedio;
    
    // Método Constructor de la Clase
    public Estudiante(string nombre, int edad, double promedio) //recibe las variables como párametros
    {
        Nombre = nombre;//asigna los valores recibidos a las variables del método
        Edad = edad;
        Promedio = promedio;
    }

    // Método para verificar si el estudiante es mayor de edad
    public bool EsMayorDeEdad() //Método booleano devuelve verdadero si se cumple la condición
    {
        return Edad >= 18;
    }

    // Método para mostrar la información del estudiante
    public void MostrarInfo()
    {
        Console.WriteLine("Nombre:"+Nombre,"Promedio:"+Promedio);//Imprime en consola los datos
    }
}

class Program //Se declara la clase del programa
{
    static void Main(string[] args) // Inicio
    {
        // Solicitar la cantidad de estudiantes
        Console.Write("Ingrese la cantidad de estudiantes que desea registrar: ");
        int cantidadEstudiantes = int.Parse(Console.ReadLine()); //guarda el dato ingresado en la variable convertido en entero

        // Crear una lista para almacenar los estudiantes
        List<Estudiante> estudiantes = new List<Estudiante>();

        // Ciclo for para ingresar los datos de cada estudiante desde 0 hasta la cantidad almacenada en la variable
        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            Console.WriteLine("\n--- Registro del estudiante"+i+1+"---"); //imprime el título con el # del estudiante i+1

            // Solicitar nombre
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            // Solicitar edad
            Console.Write("Ingrese la edad del estudiante: ");
            int edad = int.Parse(Console.ReadLine());//guarda el dato en entero

            // Solicitar promedio
            Console.Write("Ingrese el promedio del estudiante: ");
            double promedio = double.Parse(Console.ReadLine());//guarda el dato en double--> permite decimales

            // Crear un nuevo objeto Estudiante y agregarlo a la lista
            Estudiante estudiante = new Estudiante(nombre, edad, promedio); //crea el objeto estudiante con las propiedades
            estudiantes.Add(estudiante);//Agrega el nuevo objeto estudiante a la lista
        }

        // Ciclo while para mostrar los estudiantes con promedio mayor o igual a 70
        int index = 0;//declara index como una variable entera que inicia en 0
        Console.WriteLine("\n--- Estudiantes con promedio mayor o igual a 70 ---");
        while (index < estudiantes.Count) // Count propiedad que me da el total de la lista de estudiantes
        {
            Estudiante estudiante = estudiantes[index]; // accesa a cada elemento de la lista según subindice index

            if (estudiante.Promedio >= 70) //accede a la información del promedio y verifica si es mayor o igual a 70
            {
                estudiante.MostrarInfo(); // llama a la función MostrarInfo

                // Verificar si el estudiante es mayor de edad
                if (estudiante.EsMayorDeEdad())
                {
                    Console.WriteLine("Es mayor de edad.");
                }
                else
                {
                    Console.WriteLine("No es mayor de edad.");
                }
            }

            index++; //aumenta en 1 index
        }
    }
}