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
using AppNotas_Janier_Urbina;

namespace AppNotas_Janier_Urbina
{
    [Activity(Label = "ActivityNota")]
  
    public class ActivityNotas : Activity
    {
        TextView Nombre, clase;
        TextView N1, N2, NF;
        Nota nota;

        protected override void OnCreate(Bundle savedInstanceState)
        {
          
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Notas);

            Nombre = FindViewById<TextView>(Resource.Id.textNombre);
            clase = FindViewById<TextView>(Resource.Id.textClase);
            int id = Intent.GetIntExtra("id", 0);
            Alumno a = Global.Alumnos.Where(x => x.Id == ActivityAsignaturaPorAlumno.id).FirstOrDefault();
            Asignatura asi = Global.Asignaturas.Where(x => x.Id == id).FirstOrDefault();

            N1 = FindViewById<TextView>(Resource.Id.textNota1);
            N2 = FindViewById<TextView>(Resource.Id.textNota2);
            NF = FindViewById<TextView>(Resource.Id.textNotaF);
                nota = Global.Notas.Where(x => x.IdAsignatura == id && x.IdAlumno == ActivityAsignaturaPorAlumno.id).FirstOrDefault();
          
            Nombre.Text = "Estudiante: " + a.Nombre;
            clase.Text = "Asignatura: " + asi.Nombre;
                 
                double n1 = nota.Nota1;
                double n2 = nota.Nota2;
                double nf = (n1 + n2) / 2;

                N1.Text = "\t\tNota 1: " + n1;
                N2.Text = "\t\tNota 2: " + n2;
                NF.Text = "\t\tNota Final: " + nf;
                             



            //Lista = FindViewById<ListView>(Resource.Id.listView1);
            //Lista.Adapter = new AdapterNota(this, Global.Notas.Where(x => x.Id == x.IdAsignatura).ToList());



        }
    }
}