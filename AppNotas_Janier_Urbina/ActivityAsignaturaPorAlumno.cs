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
    [Activity(Label = "ActivityAsignaturaPorAlumno")]
    public class ActivityAsignaturaPorAlumno : Activity
    {
        Alumno alumno;
        TextView Nombre;
        ListView Lista;
        static public int id;
        protected override void OnCreate(Bundle savedInstanceState)
        {


            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AsignaturaPorAlumno);
            id = Intent.GetIntExtra("id", 0);
            alumno = Global.Alumnos.Where(x=>x.Id==id).FirstOrDefault();//Recupera el alumno

            //Vincular las variables con su respectivo id
            Nombre = FindViewById<TextView>(Resource.Id.textView1);
           
            Lista = FindViewById<ListView>(Resource.Id.listView1);
            Nombre.Text = alumno.Nombre;
        
            Lista.Adapter = new AdapterAsignatura(this, Global.Asignaturas.Where(x => x.Id==x.Idalumno).ToList());

            Lista.ItemClick += Lista_ItemClick;
        }

        private void Lista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityNotas));
           
            Asignatura asig = Global.Asignaturas[e.Position];
            i.PutExtra("id", asig.Id);
           
            StartActivity(i);
        }
    }
}