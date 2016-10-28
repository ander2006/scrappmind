using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using mshtml;
using System.Xml;
using System.Threading;
using System.Diagnostics;
using DTO;
using CAD;

namespace ScrappmindAg
{
    /// <summary>
    /// Interaction logic for Administrador.xaml
    /// </summary>
    public partial class Administrador : Window
    {


        public Administrador()
        {
            InitializeComponent();
        }
        private void ESPERA(int INTERVALO)
        {
            Stopwatch PARADA = new Stopwatch();
            PARADA.Start();

            do
            {
                System.Windows.Forms.Application.DoEvents();
            }


            while (PARADA.ElapsedMilliseconds < INTERVALO);


            PARADA.Stop();
        }






        private void button_Click(object sender, RoutedEventArgs e)
        {



            int counter = 0;
            string line;
            string[] datos = new string[5];

            // Read the file and display it line by line.
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"c:\test.txt");


            while ((line = file.ReadLine()) != null)
            {







                String Registraduria = "https://wsp.registraduria.gov.co/censo/_censoResultado.php";


                (Host.Child as System.Windows.Forms.WebBrowser).Navigate(Registraduria);
                (Host.Child as System.Windows.Forms.WebBrowser).ScriptErrorsSuppressed = true;

                ESPERA(3000);

                string cedula = line;


                (Host.Child as System.Windows.Forms.WebBrowser).Document.GetElementById("nCedula").InnerText = cedula;
                foreach (HtmlElement node2 in (Host.Child as System.Windows.Forms.WebBrowser).Document.GetElementsByTagName("input"))
                {
                    if (node2.GetAttribute("value").Equals("Consultar"))
                    {
                        node2.InvokeMember("Click");
                    }
                }

                // string Registraduria = @"http://registraduria.org/censo.php";
                //System.Net.WebClient wc = new System.Net.WebClient();
                //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                //doc.Load((Host.Child as System.Windows.Forms.WebBrowser).DocumentStream, System.Text.Encoding.GetEncoding("ISO-8859-1"));
                //doc.GetElementbyId("ncedula").InnerHtml = "1035417284";

                //doc.Load((Host.Child as System.Windows.Forms.WebBrowser).DocumentStream, System.Text.Encoding.GetEncoding("ISO-8859-1"));
                //HtmlNodeCollection tabla = doc.DocumentNode.SelectNodes(@"//span[@id='numcedula']");
                //ESPERA(4000);
                //textBox.Text = tabla[0].InnerText;
                //ESPERA(4000);
                //doc.Load((Host.Child as System.Windows.Forms.WebBrowser).DocumentStream, System.Text.Encoding.GetEncoding("ISO-8859-1"));
                ESPERA(4000);
                string departamento;
                string municipio;
                string puesto;
                string dirpuesto;
                string fecha;
                string mesa;
                string[] palabras = new string[12];
                int i = 0;
                foreach (HtmlElement node1 in (Host.Child as System.Windows.Forms.WebBrowser).Document.GetElementsByTagName("td"))
                {
                    palabras[i] = node1.InnerText;
                    departamento = palabras[1];
                    municipio = palabras[3];
                    puesto = palabras[5];
                    dirpuesto = palabras[7];
                    fecha = palabras[9];
                    mesa = palabras[11];

                    i++;
                }
                departamento = palabras[1];
                if (departamento == null)
                {
                    departamento = "vacio";
                }
                municipio = palabras[3];

                if (municipio == null)
                {
                    municipio = "vacio";
                }
                puesto = palabras[5];
                if (puesto == null)
                {
                    puesto = "vacio";
                }
                dirpuesto = palabras[7];
                if (dirpuesto == null)
                {
                    dirpuesto = "vacio";
                }
                fecha = palabras[9];
                if (fecha == null)
                {
                    fecha = "vacio";
                }
                mesa = palabras[11];
                if (mesa == null)
                {
                    mesa = "vacio";
                }

                DTOadministrador adm = new DTOadministrador();
                adm.Cedula = cedula;
                adm.Departamento = departamento;
                adm.Municipio = municipio;
                adm.Puesto = puesto;
                adm.Dirpuesto = dirpuesto;
                adm.Fecha = fecha;
                adm.Mesa = mesa;

                CADAdministrador datocamp = new CADAdministrador();
                datocamp.guardarCampos(adm);

            }

        }

        
    }
    
}



    //private void button1_Click(object sender, RoutedEventArgs e)
    //    {
    //        //string Registraduria = @"http://www3.registraduria.gov.co/censo/_censoresultado.php?";
    //        //System.Net.WebClient wc = new System.Net.WebClient();
    //        //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
    //        //doc.Load(wc.OpenRead(Registraduria), System.Text.Encoding.GetEncoding("ISO-8859-1"));
    //        //HtmlNodeCollection tabla = doc.DocumentNode.SelectNodes(@"//ul[@id='aviso']");
    //        //textBox.Text = tabla[0].InnerText; 

           
        
    
