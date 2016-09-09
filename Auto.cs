using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Auto : IRuedas, IMotor, ICambios
    {

        //public string ruedas;
        //public string motor;
        public int cant_cambios;
        public string tipo;
        public int diametro;
        public int cililndrada;
        bool movimiento = false;
        bool encendido = false;

        int IRuedas.diametro
        {
            get
            {
                return this.diametro;
            }

            set
            {
               
            }
        }

       


        bool IRuedas.iniciar()
        {
                this.movimiento = true;
                return this.movimiento;
        }
        bool IRuedas.frenar()
        {

                this.movimiento = true;
                return this.movimiento;
        }


        public int cilindrada
        {
            get
            {
                return this.cilindrada;
            }

            set
            {

            }
        }

        bool IMotor.frenar()
        {
            this.encendido = false;
            this.movimiento = false;
            return this.encendido;
        }


        bool IMotor.iniciar()
        {

            this.encendido = true;
            this.movimiento = true;
            return this.encendido;

        }

        int ICambios.cant_cambios
        {
            get
            {
                return this.cant_cambios;
            }

            set
            {

            }
        }

        string ICambios.tipo
        {
            get
            {
                return this.tipo;
            }

            set
            {

            }
        }


    }
}
