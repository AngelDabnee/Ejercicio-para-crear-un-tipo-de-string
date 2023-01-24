using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClaseString
{
    public class NuevoString
    {
        //Creamos los valores en modo privado para el encapsulamiento para solo poder acceder.
        private string valor;
        private int medida;
        //Se realiza los medios publicos para poderlos leer. 
        public int Medida
        {   //Get, nos da el valor o medida del objeto
            get => medida;
        }   //No incluimos el set, ya que no queremos cambiar el valor de medida, ya que nos ayudará
            //a medir la cadena y sacarnos lo que nos vale esa medida. 
        public string Valor
        {
            get
            {
                return valor;
            }
            //Nos arroja el poder cambiar el valor del objeto. 
            set
            {
                this.valor = value;
                this.medida = this.valor.Length;
            }
        }
        //Creamos los métodos para poder ser utilizados en program. 
        public NuevoString(string valor)
        {
            this.valor = valor;
            this.medida = valor.Length;


        }
    }
}
