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
        //private List<T> list = new List<T>();
        private T[] array;

        public Repositorio()
        {

        }
        public Repositorio(int _tamanio)//
        {
            array = new T[_tamanio];
        }

        public void agregar(T _item) //el tipo de dato se guardara como item
        {
            //list.Add(_item);//se añadira a la lista 
            for(int i = 0; i < array?.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = _item;
                    break;
                }
            }
        }

        public void eliminarPorIndice(int _indice)
        {
            try
            {
                //if (list[_indice] != null)// si el elemento de la lista en el indice indicado existe
                //{
                //    list.RemoveAt(_indice);//se eliminara 
                //}

                if (array[_indice] != null)// si el elemento de la lista en el indice indicado existe
                {
                    array[_indice] = default(T);//se eliminara

                    try
                    {
                        //Se recorren los elementos
                        for (int i = _indice; i < array.Length - 1; i++)
                        {
                            array[i] = array[i + 1];
                        }                        
                    }
                    catch (Exception ex)
                    {

                    }

                    
                }
            }
            catch (Exception ex)
            {
                
            }            
        }
        public void listarElementos(ref ListBox lbx)//ref:pasar por referencia un control lisbox
        {
            lbx.Items.Clear();
            //if (list.Count > 0)//count :Devuelve la cantidad de elementos que hay 
            //{
            //    foreach (dynamic item in list)//dyanamic:tipo de dato que nos permite omitir la comprobacion de la existencia de las propiedades de un objeto
            //    {
            //        lbx.Items.Add(item.id + " - " + item.nombre + " Edad: " + item.edad + " Calificación: " + item.calificacion);
            //    }
            //}

            if (array?.Length > 0)//Length :Devuelve la cantidad de elementos que hay 
            {
                foreach (dynamic item in array)//dyanamic:tipo de dato que nos permite omitir la comprobacion de la existencia de las propiedades de un objeto
                {
                    if(item != null)
                    {
                        lbx.Items.Add(item.id + " - " + item.nombre + " Edad: " + item.edad + " Calificación: " + item.calificacion);
                    }                    
                }
            }
        }

        public double calcularPromedio(int _indice = 0, double _promedio = 0)// el promedio y el indice y el promedio empezaran de 0 
        {
            //if(list.Count > 0)//si la lista tiene mas elementos que 0 
            //{
            //    try
            //    {
            //        dynamic item = list[_indiceLista];
            //        _promedio += Convert.ToInt32(item.calificacion);
            //        _indiceLista++;
            //        _promedio = calcularPromedio(_indiceLista, _promedio);//recursividad:se manda a llamar la misma funcion
            //    }
            //    catch (Exception ex)//cuando esto se deja de cumplir 
            //    {
            //        _promedio = _promedio / _indiceLista;//ya calcula el promedio
            //    }
            //}
            //return _promedio;//devuelve promedio
            if (array?.Length > 0)//si el arreglo tiene mas elementos que 0 
            {
                try
                {
                    dynamic item = array[_indice];
                    _promedio += Convert.ToInt32(item.calificacion);
                    _indice++;
                    _promedio = calcularPromedio(_indice, _promedio);//recursividad:se manda a llamar la misma funcion                   
                }
                catch (Exception ex)//cuando esto se deja de cumplir 
                {
                    _promedio = _promedio / _indice;//ya calcula el promedio
                }
            }
            return _promedio;//devuelve promedio 
        }

        public T buscarPorID(int _id, int _indice = 0)//Recursiva: por que se manda a llamar a si misma 
        {
            T elemento = default(T);

            if(array?.Length > 0)//1_valida que l total de elementos sea mayor a 0
            {
                dynamic item = array[_indice]; 
                if(item != default(T))//si nuestro item es distinto al valor por default "null"
                {
                    if (item.id == _id)//si Id en nuestro array es el mismo que estamos buscando 
                    {
                        elemento = item;//se le asignara el vlor a nuestro elemento 
                    }
                    else //si no
                    {
                        _indice++;// se incrementa el indice 
                        if (_indice < array.Length) //y si sigue siendo menor a los elementos de nuestro array
                        {
                            elemento = buscarPorID(_id, _indice);//llamar recursivamente 
                        }
                    }
                }                
            }
            

            return elemento;//devolver el valor elemento encontrado 
        }
    }
}
