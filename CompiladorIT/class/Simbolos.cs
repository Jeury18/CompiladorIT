using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorIT
{
    class Simbolos
{

        public List<Table> Simboloss = new List<Table>();
        Sentencias Tabla_Errores = new Sentencias();


        public List<Table> TablaSimbolos
        {
            get { return Simboloss; }
            set { Simboloss = value; }
        }

        public void reinicialista()
        {
            Simboloss.Clear();
        }

        public void inicialista()
        {
            Table ts = new Table("<#", "", -0, -0, -0, 0, "comentario", "inicio de un comentario de mas de una linea", "");
            Simboloss.Add(ts);
            Table ts1 = new Table("#>", "", -0, -0, -0, 1, "comentario", "final de un comentario de mas de una linea", "");
            Simboloss.Add(ts1);
            Table ts2 = new Table("<<", "", -0, -0, -0, 2, "comentario", "inicio de un comentario de una linea", "");
            Simboloss.Add(ts2);
            Table ts3 = new Table(".float", "", -0, -0, -0, 3, "palabra reservada", "numero flotante", "");
            Simboloss.Add(ts3);
            Table ts4 = new Table("{", "", -0, -0, -0, 4, "bloque", "inicio de un bloque", "");
            Simboloss.Add(ts4);
            Table ts5 = new Table("}", "", -0, -0, -0, 5, "bloque", "final de un bloque", "");
            Simboloss.Add(ts5);
            Table ts6 = new Table(".integer", "", -0, -0, -0, 6, "palabra reservada", "numero entero", "");
            Simboloss.Add(ts6);
            Table ts7 = new Table(".double", "", -0, -0, -0, 8, "palabra reservada", "numero con decimales", "");
            Simboloss.Add(ts7);
            Table ts8 = new Table(".String", "", -0, -0, -0, 9, "palabra reservada", "cadena de caracteres", "");
            Simboloss.Add(ts8);
            Table ts9 = new Table(".booleano", "", -0, -0, -0, 10, "palabra reservada", "booleano true o false", "");
            Simboloss.Add(ts9);
            Table ts10 = new Table("->", "", -0, -0, -0, 12, "asignacion", "simbolo de asignacion", "");
            Simboloss.Add(ts10);
            Table ts11 = new Table(";", "", -0, -0, -0, 13, "posicionador", "final de linea", "");
            Simboloss.Add(ts11);
            Table ts12 = new Table("'", "", -0, -0, -0, 14, "indicador de texto", "inicio y final de un texto", "");
            Simboloss.Add(ts12);
            Table ts13 = new Table("/l", "", -0, -0, -0, 15, "posicionador", "salto de linea en un texto", "");
            Simboloss.Add(ts13);
            Table ts14 = new Table("[", "", -0, -0, -0, 16, "arreglo", "inicio de asignacion de un arreglo", "");
            Simboloss.Add(ts14);
            Table ts15 = new Table("]", "", -0, -0, -0, 17, "arreglo", "final de asignacion de un arreglo", "");
            Simboloss.Add(ts15);
            Table ts16 = new Table("+", "", -0, -0, -0, 18, "operador", "suma", "");
            Simboloss.Add(ts16);
            Table ts17 = new Table("-", "", -0, -0, -0, 20, "operador", "resta", "");
            Simboloss.Add(ts17);
            Table ts18 = new Table("*", "", -0, -0, -0, 21, "operador", "multiplicacion", "");
            Simboloss.Add(ts18);
            Table ts19 = new Table("/", "", -0, -0, -0, 22, "operador", "division", "");
            Simboloss.Add(ts19);
            Table ts20 = new Table("~", "", -0, -0, -0, 23, "signo relacionador", "negacion", "");
            Simboloss.Add(ts20);
            Table ts21 = new Table(">", "", -0, -0, -0, 24, "signo comparador", "mayor que", "");
            Simboloss.Add(ts21);
            Table ts22 = new Table("<", "", -0, -0, -0, 25, "signo comparador", "menor que", "");
            Simboloss.Add(ts22);
            Table ts23 = new Table(">->", "", -0, -0, -0, 26, "signo comparador", "mayor o igual que", "");
            Simboloss.Add(ts23);
            Table ts24 = new Table("<->", "", -0, -0, -0, 27, "signo comparador", "menor o igual que", "");
            Simboloss.Add(ts24);
            Table ts25 = new Table("&&", "", -0, -0, -0, 28, "signo relacionador", "expresion y (and)", "");
            Simboloss.Add(ts25);
            Table ts26 = new Table("||", "", -0, -0, -0, 29, "signo relacionador", "expresion or", "");
            Simboloss.Add(ts26);
            Table ts27 = new Table("->->", "", -0, -0, -0, 30, "signo comparador", "expresion igual", "");
            Simboloss.Add(ts27);
            Table ts28 = new Table("!=", "", -0, -0, -0, 31, "signo comparador", "expresion distinto", "");
            Simboloss.Add(ts28);
            Table ts29 = new Table("si", "", -0, -0, -0, 32, "palabra reservada", "si tal condicion se cumple", "");
            Simboloss.Add(ts29);

            Table ts30 = new Table("entonces", "", -0, -0, -0, 34, "palabra reservada", "si no se cumple la condicion", "");
            Simboloss.Add(ts30);
            Table ts31 = new Table(".switch", "", -0, -0, -0, 35, "palabra reservada", "opciones (casos)", "");
            Simboloss.Add(ts31);
            Table ts32 = new Table(".caso", "", -0, -0, -0, 36, "palabra reservada", "caso", "");
            Simboloss.Add(ts32);

            Table ts33 = new Table(".mientras", "", -0, -0, -0, 38, "palabra reservada", "ciclo while", "");
            Simboloss.Add(ts33);
            Table ts34 = new Table(".para", "", -0, -0, -0, 39, "palabra reservada", "ciclo for", "");
            Simboloss.Add(ts34);
            Table ts35 = new Table(".foreach", "", -0, -0, -0, 40, "palabra reservada", "ciclo foreach", "");
            Simboloss.Add(ts35);
            Table ts36 = new Table(".try", "", -0, -0, -0, 42, "palabra reservada", "intenta realizar el codigo contenido", "");
            Simboloss.Add(ts36);
            Table ts37 = new Table(".catch", "", -0, -0, -0, 43, "palabra reservada", "muestra una accion a seguir en caso de error", "");
            Simboloss.Add(ts37);
            Table ts38 = new Table("salida", "", -0, -0, -0, 44, "palabra reservada", "muestra en consola", "");
            Simboloss.Add(ts38);
            Table ts39 = new Table(".Console.leeLine", "", -0, -0, -0, 45, "palabra reservada", "pide en consola", "");
            Simboloss.Add(ts39);
            Table ts40 = new Table(".class", "", -0, -0, -0, 47, "palabra reservada", "clase", "");
            Simboloss.Add(ts40);
            Table ts41 = new Table("(", "", -0, -0, -0, 48, "parametro", "inicia peticion de parametro", "");
            Simboloss.Add(ts41);
            Table ts42 = new Table(")", "", -0, -0, -0, 49, "parametro", "termina peticion de parametro", "");
            Simboloss.Add(ts42);
            Table ts43 = new Table("+", "", -0, -0, -0, 50, "concatenador", "concatena variables", "");
            Simboloss.Add(ts43);
            Table ts44 = new Table(".break", "", -0, -0, -0, 50, "palabra reservada", "rompe un ciclo", "");
            Simboloss.Add(ts44);
            Table ts45 = new Table(".long", "", -0, -0, -0, 50, "palabra reservada", "entero con signo", "");
            Simboloss.Add(ts45);
            Table ts46 = new Table(".byte", "", -0, -0, -0, 50, "palabra reservada", "entero sin signo", "");
            Simboloss.Add(ts46);
            Table ts47 = new Table(".short", "", -0, -0, -0, 50, "palabra reservada", "entero con signo", "");
            Simboloss.Add(ts47);
            Table ts48 = new Table("entonces si", "", -0, -0, -0, 50, "palabra reservada", "entero con signo", "");
            Simboloss.Add(ts48);
        }


        public List<Table> llamatabla()
        {
            return Simboloss;
        }

        public void añadir_obj(Table Ts)
        {
            Simboloss.Add(Ts);
        }

        public bool compararAL(string argsplit)
        {
            bool comp = false;
            foreach (var palabra in Simboloss)
            {

                if (palabra.simbolo == argsplit)
                {
                    comp = true;
                    break;
                }
                else
                {
                    comp = false;
                }

            }
            return comp;
        }

        public bool busca_dupl()
        {
            bool flag = false;

            foreach (var sent1 in Simboloss)
            {
                foreach (var sent2 in Simboloss)
                {
                    if (sent1.ID == sent2.ID)
                    {

                        flag = true;


                    }
                }
            }
            return flag;
        }

        public void comparacion_semantic()
        {

            foreach (var palabra in Simboloss)
            {
                foreach (var palabra2 in Simboloss)
                {
                    if (palabra.Simbolo == palabra2.Simbolo)
                    {
                        palabra2.Tipo_Dato = palabra.Tipo_Dato;
                    }
                }
            }

        }



        public int compararALRef(string argsplit)
        {
            int id = 0;
            foreach (var palabra in Simboloss)
            {

                if (palabra.simbolo == argsplit)
                {
                    id = palabra.id;
                    break;
                }
                else
                {
                    id = 0;
                }

            }
            return id;
        }


        public int contlineas()
        {
            int numid = 0;
            foreach (var nlinea in Simboloss)
            {
                numid = numid + 1;
            }
            return numid - 1;
        }
    }
}
