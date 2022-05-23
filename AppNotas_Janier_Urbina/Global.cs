using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppNotas_Janier_Urbina
{
    internal class Global
    {
        //Definir las listas con sus valores
        public static List<Alumno> Alumnos = new List<Alumno>()
        {
            new Alumno(1,"Abel Gerardo Aballay"),
            new Alumno(2," Ricardo Aballay")    ,
            new Alumno(3," Arredondo Roberto")  ,
            new Alumno(4," Martín Matías Carrizo"),
            new Alumno(5," Mairo Leonardo Castro"),
            new Alumno(6," Germán Cruz-Molina")
        };
        public static List<Asignatura> Asignaturas = new List<Asignatura>()
        {
            new Asignatura(1,"MATEMÁTICAS",1),
            new Asignatura(2,"PROYECTO",1),
            new Asignatura(3,"HISTORIA",1),
            new Asignatura(4,"TECNOLOGIA",1),
            new Asignatura(5,"LENGUA",1),
            new Asignatura(6,"INGLÉS",1),

            new Asignatura(1,"MATEMÁTICAS",2),
            new Asignatura(2,"PROYECTO",2),
            new Asignatura(3,"HISTORIA",2),
            new Asignatura(4,"TECNOLOGIA",2),
            new Asignatura(5,"LENGUA",2),
            new Asignatura(6,"INGLÉS",2),

            new Asignatura(1,"MATEMÁTICAS",3),
            new Asignatura(2,"PROYECTO",3),
            new Asignatura(3,"HISTORIA",3),
            new Asignatura(4,"TECNOLOGIA",3),
            new Asignatura(5,"LENGUA",3),
            new Asignatura(6,"INGLÉS",3),

            new Asignatura(1,"MATEMÁTICAS",4),
            new Asignatura(2,"PROYECTO",4),
            new Asignatura(3,"HISTORIA",4),
            new Asignatura(4,"TECNOLOGIA",4),
            new Asignatura(5,"LENGUA",4),
            new Asignatura(6,"INGLÉS",4),

            new Asignatura(1,"MATEMÁTICAS",5),
            new Asignatura(2,"PROYECTO",5),
            new Asignatura(3,"HISTORIA",5),
            new Asignatura(4,"TECNOLOGIA",5),
            new Asignatura(5,"LENGUA",5),
            new Asignatura(6,"INGLÉS",5),

            new Asignatura(1,"MATEMÁTICAS",6),
            new Asignatura(2,"PROYECTO",6),
            new Asignatura(3,"HISTORIA",6),
            new Asignatura(4,"TECNOLOGIA",6),
            new Asignatura(5,"LENGUA",6),
            new Asignatura(6,"INGLÉS",6)

         };



        public static List<Nota> Notas = new List<Nota>()
        {
            
            new Nota(1,7,7,1,1),
            new Nota(2,8,5,1,2),
            new Nota(3,5,8,1,3),
            new Nota(4,6,9,1,4),
            new Nota(5,7,8,1,5),
            new Nota(6,10,6,1,6)
                               ,
            new Nota(7,8,5,2,1),
            new Nota(8,4,6,2,2),
            new Nota(9,6,5,2,3),
            new Nota(10,8,7,2,4),
            new Nota(11,6,7.5,2,5),
            new Nota(12,7,5.9,2,6),

            new Nota(13,7,7,3,1),
            new Nota(14,8,5,3,2),
            new Nota(15,5,8,3,3),
            new Nota(16,6,9,3,4),
            new Nota(17,7,8,3,5),
            new Nota(18,10,6,3,6),

            new Nota(19,8,5,4,1),
            new Nota(20,4,6,4,2),
            new Nota(21,6,5,4,3),
            new Nota(22,8,7,4,4),
            new Nota(23,6,7.5,4,5),
            new Nota(24,7.5,9,4,6),

            new Nota(25,7,7,5,1),
            new Nota(26,8,5,5,2),
            new Nota(27,5,8,5,3),
            new Nota(28,6,9,5,4),
            new Nota(29,7,8,5,5),
            new Nota(30,10,6,5,6),

            new Nota(31,8,5,6,1),
            new Nota(32,4,6,6,2),
            new Nota(33,6,5,6,3),
            new Nota(34,8,7,6,4),
            new Nota(35,6,7.5,6,5),
            new Nota(36,7.5,9,6,6)
        };
    }




    //Definir las estructuras


   
    public class Alumno
    {
        //Campos
        int id;
        string nombre;

        public Alumno(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
    public class Asignatura
    {
        int id;
        string nombre;
        int idalumno;

        public Asignatura(int id, string nombre, int idalumno)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Idalumno = idalumno;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Idalumno { get => idalumno; set => idalumno = value; }
    }
    public class Nota
    {
        int id;
        double nota1;
        double nota2;
        int idAlumno;
        int idAsignatura;

        public Nota(int id, double nota1, double nota2, int idAlumno, int idAsignatura)
        {
            this.Id = id;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.IdAlumno = idAlumno;
            this.IdAsignatura = idAsignatura;
        }

        public int Id { get => id; set => id = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public int IdAsignatura { get => idAsignatura; set => idAsignatura = value; }
    }
}