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
    //2. Implementar clase abstracta
    internal class AdapterAsignatura : BaseAdapter //1. Para indicar que funcione como adaptador
    {
        //Campos
        Activity context;
        List<Asignatura> Lista;

        //Generamos el constructor
        public AdapterAsignatura(Activity context, List<Asignatura> lista)
        {
            this.context = context;
            Lista = lista;
        }

        public override int Count => Lista.Count();

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //El elemento devuelto
            var item = Lista[position];

            //Definimos el formato de la fila
            View view = convertView;

            if(view == null)
            {
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);
                view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nombre;

                view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = Global.Asignaturas.Where(x=>x.Id==item.Id).Count().ToString();
               
            }
            return view;
        }
    }
}