using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_integrador
{
    public class Repositorio<T>//creacion de la clase generica "Repositorio"
    {
        private List<T> list = new List<T>();

        public void agregar(T _item) //el tipo de dato se guardara como item
        {
            list.Add(_item);//se añadira a la lista 
        }

        public void eliminarPorIndice(int _indice)
        {
            try
            {
                if (list[_indice] != null)//si el indice esta en la lista 
                {
                    list.RemoveAt(_indice);//se eliminara 
                }
            }
            catch (Exception ex)
            {
                
            }            
        }
        public void listarElementos(ref ListBox lbx)//ref:pasar por referencia un control lisbox
        {
            lbx.Items.Clear();
            if (list.Count > 0)//count :Devuelve la cantidad de elementos que hay 
            {
                foreach (dynamic item in list)//dyanamic:tipo de dato que nos permite omitir la comprobacion de la existencia de las propiedades de un objeto
                {
                    lbx.Items.Add(item.id + " - " + item.nombre + " Edad: " + item.edad + " Calificación: " + item.calificacion);
                }
            }            
        }

        public double calcularPromedio(int _indiceLista = 0, double _promedio = 0)// el promedio y el indice y el promedio empezaran de 0 
        {
            if(list.Count > 0)//si la lista tiene mas elementos que 0 
            {
                try
                {
                    dynamic item = list[_indiceLista];
                    _promedio += Convert.ToInt32(item.calificacion);
                    _indiceLista++;
                    _promedio = calcularPromedio(_indiceLista, _promedio);//recursividad:se manda a llamar la misma funcion
                }
                catch (Exception ex)//cuando esto se deja de cumplir 
                {
                    _promedio = _promedio / _indiceLista;//ya calcula el promedio
                }
            }
            return _promedio;//devuelve promedio 
        }
    }
}
