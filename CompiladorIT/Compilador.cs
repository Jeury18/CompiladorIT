using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiladorIT
{
    public partial class compilador : Form
    {
        public compilador()
        {
            InitializeComponent();
        }

        private void compilar_Click(object sender, EventArgs e)
        {
            tabla_simb = new Simbolos();
            CodigoSalida.Text = "";
            tabla_errorres.inicialestaE();
            leer_texto(CodigoEntrada.Text);
            string[] sent = une_tokens();
            tabla_simb.comparacion_semantic();

            Analisis_Sint_Sem(sent);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            CodigoEntrada.Text = "";
            CodigoSalida.Text = "";
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int cantLineas = 0;

        Sentencias tabla_errorres = new Sentencias();
        Simbolos tabla_simb = new Simbolos();
        Simbolos tabla_simb2 = new Simbolos();

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void leer_texto(string texto)
        {

            int contador_Ambitoi = 0;
            int contador_Ambitf = 0;
            int ambito = 0;

            string Rtexto = "";

            Rtexto = CodigoEntrada.Text;

            try
            {
                string[] palabra_sep;
                int num_lineas = CodigoEntrada.Lines.Length;

                int num_line_token = 0;

                while (Rtexto != "")
                {
                    palabra_sep = CodigoEntrada.Text.Split(' ');
                    foreach (var palabra in palabra_sep)
                    {
                        num_line_token = num_line_token + 1;

                        if (palabra == "{")
                        {
                            contador_Ambitoi = contador_Ambitoi + 1;
                        }
                        if (palabra == "}")
                        {
                            contador_Ambitf = contador_Ambitf + 1;
                        }
                        ambito = contador_Ambitoi;

                        if (tabla_simb2.compararAL(palabra.ToString()) && palabra != null)
                        {

                            Table obj = new Table(palabra, "", num_line_token, -0, ambito, tabla_simb2.compararALRef(palabra.ToString()), "palabra nueva", "palabra contenida en la tabla de simbolos", "");
                            tabla_simb.añadir_obj(obj);
                        }
                        else
                        {
                            if (Regex.IsMatch(palabra, @"[a-zA-Z]") && palabra != null)
                            {
                                Table obj = new Table(palabra, "", num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "palabra nueva", "palabra que no coincide con la Tabla de simbolos,pero no se considera error", "");
                                tabla_simb.añadir_obj(obj);
                            }
                            else if (Regex.IsMatch(palabra, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}") && palabra != null)
                            {
                                Table obj = new Table(palabra, palabra, num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "numero nuevo", "numero", "");
                                tabla_simb.añadir_obj(obj);
                            }
                            else if (palabra != null && palabra == "->")
                            {
                                Table obj = new Table(palabra, palabra, num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "numero nuevo", "numero", "");
                                tabla_simb.añadir_obj(obj);
                            }
                        }
                    }
                    palabra_sep = null;
                    Rtexto = "";
                    cantLineas = num_lineas;
                }
                if (contador_Ambitf != contador_Ambitoi)
                {
                    tabla_errorres.agrega_error(8);

                }

            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("Error");

                tabla_errorres.agrega_error(2);
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }


        }

        public string[] une_tokens()
        {
            string sentencia = null;
            int tam = 1;
            string[] sentencias = new string[tam + 1];

            int comp = 0;

            string tipov = "";
            List<string> Ltoken = new List<string>();

            for (int i = 1; i <= tam; i++)
            {
                foreach (var token in tabla_simb.llamatabla())
                {
                    if (token.num_linea == i && token != null)
                    {
                        if (comp == 0 && Regex.IsMatch(token.Simbolo, @"(.integer|.float|.double|.booleano|.String)$"))
                        {

                            token.Tipo_Dato = token.Simbolo;
                            tipov = token.Simbolo;
                        }


                        if (comp != 0)
                        {
                            sentencia = sentencia + " " + token.simbolo.ToString();
                            token.Tipo_Dato = tipov;
                        }
                        else
                        {
                            sentencia = sentencia + token.simbolo.ToString();
                            comp = 1;
                        }

                    }
                    else
                    {

                        sentencia = sentencia + " " + token.simbolo.ToString();
                    }
                }
                sentencias[i] = sentencia;
                sentencia = null;
                comp = 0;
                tipov = "";
            }

            return sentencias;
        }

        public void Analisis_Sint_Sem(string[] sentencias)
        {
            List<string> sintaxisLNV = new List<string>();

            int cantidad = 0;

            for (int j = 0; j < sentencias.Length; j++)
            {
                if (sentencias[j] != null)
                    cantidad = System.Text.RegularExpressions.Regex.Matches(sentencias[j], "\n").Count;

            }

            for (int i = 1; i < sentencias.Length; i++)
            {


                if (sentencias[i] != null)
                {
                    for (int a = 0; a < cantidad; a++)
                    {
                        if (sentencias[i].Contains(".integer") && !sintaxisLNV.Contains(".integer"))
                        {
                            sintaxisLNV.Add(".integer");

                            string[] separanum;
                            separanum = sentencias[i].Split(' ');


                            try
                            {
                                sentencias[i] = sentencias[i].Replace(".integer", "int");
                                if (sentencias[i].Contains("->"))
                                    sentencias[i] = sentencias[i].Replace("->", "=");


                            }
                            catch (FormatException e)
                            {

                                tabla_errorres.agrega_error_l(0, i);

                            }
                            catch (IndexOutOfRangeException e)
                            {

                                tabla_errorres.agrega_error_l(10, i);
                            }



                        }

                        else if (sentencias[i].Contains(".double") && !sintaxisLNV.Contains(".double"))
                        {
                            sintaxisLNV.Add(".double");
                            string[] separanum;
                            separanum = sentencias[i].Split(' ');
                            try
                            {
                                sentencias[i] = sentencias[i].Replace(".double", "double");
                                if (sentencias[i].Contains("->"))
                                    sentencias[i] = sentencias[i].Replace("->", "=");

                                double num;
                                num = double.Parse(separanum[3]);


                            }
                            catch (FormatException e)
                            {
                                tabla_errorres.agrega_error_l(0, i);


                            }
                            catch (IndexOutOfRangeException e)
                            {

                                tabla_errorres.agrega_error_l(10, i);


                            }


                        }
                        else if (sentencias[i].Contains(".String") && !sintaxisLNV.Contains(".String"))
                        {
                            sintaxisLNV.Add(".String");
                            sentencias[i] = sentencias[i].Replace(".String", "String");
                            if (sentencias[i].Contains("->"))
                                sentencias[i] = sentencias[i].Replace("->", "=");

                        }
                        else if (sentencias[i].Contains(".booleano") && !sintaxisLNV.Contains(".booleano"))
                        {
                            sintaxisLNV.Add(".booleano");


                            string[] separavar;
                            separavar = sentencias[i].Split(' ');
                            try
                            {
                                sentencias[i] = sentencias[i].Replace(".booleano", "bool");
                                if (sentencias[i].Contains("->"))
                                    sentencias[i] = sentencias[i].Replace("->", "=");

                                bool var;
                                var = bool.Parse(separavar[3]);

                            }
                            catch (FormatException e)
                            {

                                tabla_errorres.agrega_error_l(0, i);
                            }

                        }
                        else if (sentencias[i].Contains("<<") && !sintaxisLNV.Contains(".<<"))
                        {
                            sintaxisLNV.Add(".<<");
                            sentencias[i] = sentencias[i].Replace("<<", "//");
                            if (sentencias[i].Contains("->"))
                                sentencias[i] = sentencias[i].Replace("->", "=");
                        }
                        else if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s[a-z]|(\w)*\s\+\s(\w)*|\d(0,32000)*\s;$") && !sintaxisLNV.Contains("->"))
                        {
                            sintaxisLNV.Add("->");
                            if (sentencias[i].Contains("->"))
                                sentencias[i] = sentencias[i].Replace("->", "=");

                            string tpv1 = "";
                            string tpv2 = "";
                            string tpv3 = "";

                            string[] separavar;
                            separavar = sentencias[i].Split(' ');

                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\+\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("el tipo de las variables son el mismo");
                                }
                            }
                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\-\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("El tipo de las variables son iguales");
                                }
                            }
                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\/\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("El tipo de las variables son iguales");
                                }
                            }
                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\*\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("El tipo de las variables son iguales");
                                }
                            }

                        }

                        else if (sentencias[i].Contains("si") && !sintaxisLNV.Contains("si"))
                        {
                            sintaxisLNV.Add("si");
                            sentencias[i] = sentencias[i].Replace("si", "if");
                        }
                        else if (sentencias[i].Contains("entonces") && !sintaxisLNV.Contains("entonces"))
                        {
                            sintaxisLNV.Add("sentonces");
                            sentencias[i] = sentencias[i].Replace("entonces", "else ");
                        }
                        else if (sentencias[i].Contains("entonces si") && !sintaxisLNV.Contains("entonces si"))
                        {
                            sintaxisLNV.Add("entonces si");
                            sentencias[i] = sentencias[i].Replace("entonces si", "else if");
                        }
                        else if (sentencias[i].Contains(".ent") && !sintaxisLNV.Contains(".ent"))
                        {
                            sintaxisLNV.Add("entonces");
                            sentencias[i] = sentencias[i].Replace("entonces", "else");
                        }
                        else if (sentencias[i].Contains(".switch") && !sintaxisLNV.Contains(".switch"))
                        {
                            sintaxisLNV.Add(".switch");
                            sentencias[i] = sentencias[i].Replace(".switch", "switch");
                        }
                        else if (sentencias[i].Contains(".caso") && !sintaxisLNV.Contains(".caso"))
                        {
                            sintaxisLNV.Add(".caso");
                            sentencias[i] = sentencias[i].Replace(".caso", "case");
                        }
                        else if (sentencias[i].Contains("break") && !sintaxisLNV.Contains(".break"))
                        {
                            sintaxisLNV.Add(".break");

                            sentencias[i] = sentencias[i].Replace(".break", "break");
                        }
                        else if (sentencias[i].Contains(".mientras") && !sintaxisLNV.Contains(".mientras"))
                        {
                            sintaxisLNV.Add(".mientras");
                            sentencias[i] = sentencias[i].Replace(".mientras", "while");
                        }

                        else if (sentencias[i].Contains("salida") && !sintaxisLNV.Contains("salida"))
                        {
                            sintaxisLNV.Add("salida");
                            sentencias[i] = sentencias[i].Replace("salida", "print");

                        }
                        else
                        {
                            if (sentencias[i] != null)
                            {
                                tabla_errorres.agrega_error_l(9, i);
                            }
                        }
                    }

                }
            }
            for (int i = 0; i < sentencias.Length; i++)
            {
                if (sentencias[i] != null)
                    CodigoSalida.Text += sentencias[i];
            }


        }

        private void Principal_Load(object sender, EventArgs e)
        {
            tabla_simb2.inicialista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
