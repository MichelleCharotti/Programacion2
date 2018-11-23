﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        public int CantidadDePaginas {
            get{
                if (this._cantidadDePaginas == 0)
                {
                    this._cantidadDePaginas = Libro._generadorDePaginas.Next(10,580);
                }
                return this._cantidadDePaginas;
            } 
            }

         static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }
        public Libro(float precio,string titulo,string nombre,string apellido)
        {
            this._precio = precio;
            this._titulo = titulo;
            this._autor = new Autor(nombre, apellido);
        }
        public Libro (string titulo, Autor autor,float precio)
        {
            this._precio = precio;
            this._titulo = titulo;
            this._autor = autor;
        }

        private string Mostrar(Libro l)
        {
            return (string)l;
        }

        public static implicit operator string(Libro l)
        {
            return  " TITULO: " + l._titulo+"\n" + l._autor+ "\nCANTIDAD DE PAGINAS: " + l.CantidadDePaginas+"\nPRECIO: " + l._precio ;
        }
        public static bool operator==(Libro a,Libro b)
        {
            return (a._titulo == b._titulo && a._autor == b._autor);
        }
        public static bool operator !=(Libro a,Libro b)
        {
            return !(a==b);
        }
    }

}
