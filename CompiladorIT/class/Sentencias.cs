using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorIT
{
    class Sentencias
{
         public List<Variables> error = new List<Variables>();
        public List<Variables> table_error = new List<Variables>();


        public List<Variables> TablaErrores
        {
            get { return error; }
            set { error = value; }
        }
        public void reinicialista()
        {
            error.Clear();
            table_error.Clear();
        }
        public void inicialestaE()
        {

            Variables te = new Variables(0, "valor incorrecto", "escriba el valor aceptado por el tipo de variable", "valor diferente al aceptado por el tipo");
            error.Add(te);

            Variables te1 = new Variables(1, "se espera un valor", "escriba un valor para la variable ", "se espera un valor despues de...");
            error.Add(te1);


            Variables te3 = new Variables(3, "error aritmetico", "revise la operación que esta realizando", "excepciones producidas durante operaciones aritméticas");
            error.Add(te3);

            Variables te4 = new Variables(4, "error dividir por cero ", "escoja otro numero que no sea el 0 para dividir", "posible incongruencia en divicion,o en cualquier operación");
            error.Add(te4);

            Variables te5 = new Variables(5, "error de conversion de tipo", "verifique que los tipos de las variables sea el mismo ", "Se produce cuando tiene lugar un error en tiempo de ejecución en una conversión explícita de un tipo base a una interfaz o a un tipo derivado.");
            error.Add(te5);

            Variables te6 = new Variables(6, "error referencia nula", "revise que esta dando un valor a la variable", "Se produce al intentar hacer referencia a un objeto cuyo valor es null.");
            error.Add(te6);

            Variables te7 = new Variables(7, "error de desbordamiento", "asegurese del tamaño del resultado ", "Se produce cuando una operación aritmética en un contexto produce un desbordamiento.");
            error.Add(te7);
            Variables te8 = new Variables(8, "error de Ambito", "asegurese de que las llaves '{' tengan su contraparte '}' ", "Se produce cuando hay alguna llave sin cerrar, ambito incompleto");
            error.Add(te8);
            Variables te9 = new Variables(9, "sintaxis desconocida", "asegurese de que la sintaxis sea correcta ", "Se produce cuando se desconoce la sintaxis de la sentencia");
            error.Add(te9);
            Variables te10 = new Variables(10, "sintaxis erronea", "asegurese de que la sintaxis sea correcta, verifique espacios ", "Se produce cuando la sintaxis de la sentencia contiene algun error");
            error.Add(te10);
            Variables te11 = new Variables(11, "warning", "asegurese de que las variables no esten repetidas ", "Se produce cuando mas de una variable estan inicializadas con el mismo nombre");
            error.Add(te11);


        }

        public List<Variables> llamatablaE()
        {
            return table_error;
        }



        public void agrega_error_l(int id, int nl)
        {
            foreach (var error in error)
            {

                if (error.Id == id)
                {
                    Variables er = new Variables();
                    er.Descripcion = error.Descripcion;
                    er.Recomendacion = error.Recomendacion;
                    er.Error = error.Error;
                    er.num_linea = nl;
                    table_error.Add(er);
                }

            }

        }
        public void agrega_error(int id)
        {
            foreach (var error in error)
            {

                if (error.Id == id)
                {
                    Variables er = new Variables();
                    er.Descripcion = error.Descripcion;
                    er.Recomendacion = error.Recomendacion;
                    er.Id = error.Id;
                    table_error.Add(er);
                }

            }

        }

    }
}

