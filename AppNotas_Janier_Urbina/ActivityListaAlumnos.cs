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
    [Activity(Label = "ActivityListaAlumnos", MainLauncher = false)]
    public class ActivityListaAlumnos : Activity
    {
        ListView Lista;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ListaAlumnos);
            Lista = FindViewById<ListView>(Resource.Id.listView1);

            //Vinculamos la fuente de los datos con el listview mediante el AdapterAlumno
            Lista.Adapter = new AdapterAlumno(this, Global.Alumnos);

            Lista.ItemClick += Lista_ItemClick;
        }

        private void Lista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityAsignaturaPorAlumno));

            //Obtener el id del id seleccionado
            Alumno alumno = Global.Alumnos[e.Position];
            i.PutExtra("id", alumno.Id);
            StartActivity(i);
        }
    }
}