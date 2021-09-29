using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALL_PROYECTOS
{
    public partial class MENU_PRINCIPAL : Form
    {
        int animacion = 0;

        public MENU_PRINCIPAL()
        {
            InitializeComponent();
            INICIAR.Visible = false;
            IMAGEN.Visible = false;

            WRAPPER.Location = new Point(240,50);

            //ORIGINAL POSITION: 814; 50
            SIDEWRAPPER.Location = new Point(1300,50);

            btnINSTALARFUENTES.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int programa;
        private void btnORDENAMIENTO_Click(object sender, EventArgs e)
        {          
            INICIAR.Visible = true;
            IMAGEN.Visible = true;

            TITULO.Text = "RPYECTO #1";
            SUBTITULO.Text = "MÉTODOS DE BUSQUEDA Y ORDENAMIENTO";
            DESCRIPCION.Text = "Proyecto diseñado para la aplicacion de los\n" +
                "métodos de busqueda y ordenamiento mas\n" +
                "importantes usados en el area de programación.";

            programa = 1;
            IMAGEN.Image = Properties.Resources.ORDENAMIENTOYBUSQUEDA_IMG;

            ACOMODAR();
        }
        private void btnGRAFO_Click(object sender, EventArgs e)
        {
            INICIAR.Visible = true;
            IMAGEN.Visible = true;

            TITULO.Text = "RPYECTO #2";
            SUBTITULO.Text = "GRAFO MAKER";
            DESCRIPCION.Text = "Proyecto diseñado para la aplicacion de grafos\n" +
                "dieñado con una interfaz amigable y didactica\n" +
                "donde tambien se desarrollaron los métodos de\n" +
                "recorridos (BFS y DFS) como el algoritmo del\n" +
                "camino mas corto (DIJSKTRA).";

            programa = 2;
            IMAGEN.Image = Properties.Resources.GRAFOMAKER_IMG;
            ACOMODAR();
        }
        private void btnRECURSIVIDAD_Click(object sender, EventArgs e)
        {
            INICIAR.Visible = true;
            IMAGEN.Visible = true;

            TITULO.Text = "RPYECTO #3";
            SUBTITULO.Text = "FUNCIONES RECURSIVAS";
            DESCRIPCION.Text = "Proyecto diseñado para el desarrollo de\n" +
                "programacion dinamica (recursividad) resolviendo\n" +
                "problemas didacticos t mostrando el funcionamiento\n" +
                "de los algoritmos.";

            programa = 3;
            IMAGEN.Image = Properties.Resources.RECURSIVIDAD_IMG;

            ACOMODAR();
        }
        private void btnMEMOIZACION_Click(object sender, EventArgs e)
        {
            INICIAR.Visible = true;
            IMAGEN.Visible = true;

            TITULO.Text = "RPYECTO #4";
            SUBTITULO.Text = "PROGRAMACION DINAMICA Y MEMOIZACION";
            DESCRIPCION.Text = "Proyecto diseñado para el desarrollo de\n" +
                "programacion dinamica (recursividad) y la aplicación\n" +
                "del concepto de memoizacion, evaluando la velocidad\n" +
                "y eficiencia de cada algoritmo (fibonacci) programado.";

            programa = 4;
            IMAGEN.Image = Properties.Resources.MEMOIZACION_IMG;

            ACOMODAR();
        }
        private void btnCUATROCUATROS_Click(object sender, EventArgs e)
        {
            INICIAR.Visible = true;
            IMAGEN.Visible = true;

            TITULO.Text = "RPYECTO #5";
            SUBTITULO.Text = "LOS CUATRO CUATROS";
            DESCRIPCION.Text = "Proyecto diseñado para la aplicacion\n" +
                "de grafos. Desarrollado bajo un entorno e interfaz\n" +
                "de videojuego. Basado en el libro de Malba Tahan:\n" +
                "El hombre que calculaba y el problema de los cuatro\n" +
                "cuatros.";

            programa = 5;
            IMAGEN.Image = Properties.Resources.CUATROCUATROS_IMG;

            ACOMODAR();
        }
        private void btnBACKTRACKING_Click(object sender, EventArgs e)
        {
            INICIAR.Visible = true;
            IMAGEN.Visible = true;

            TITULO.Text = "RPYECTO #6";
            SUBTITULO.Text = "BACKTRACKING";
            DESCRIPCION.Text = "Proyecto diseñado para la aplicacion\n" +
                "de Backtracking en el problema de la mochila. Diseñado\n" +
                "con una muy atractiva interfaz y buen control de\n" +
                "validacion de datos.";

            programa = 6;
            IMAGEN.Image = Properties.Resources.BACKTRACKING1;

            ACOMODAR();
        }

        int var = 0;
        private void INICIAR_Click(object sender, EventArgs e)
        {
            if (var == 0)
            {
                DialogResult DR = new DialogResult();
                DR = MessageBox.Show("ANTES DE EJECUTAR CUALQUIER APLICATIVO, ES RECOMENDABLE INSTALAR LAS FUENTES NECESARIAS","ATENCION", MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (DR == DialogResult.OK)
                {
                    btnINSTALARFUENTES.Visible = true;
                }
                var = 1;
            }
            else
            {
                if (programa == 1)
                    System.Diagnostics.Process.Start("bin\\Metodos.exe");
                if (programa == 2)
                    System.Diagnostics.Process.Start("bin\\ProyectoGrafos.exe");
                if (programa == 3)
                    System.Diagnostics.Process.Start("bin\\Recursividad.exe");
                if (programa == 4)
                    System.Diagnostics.Process.Start("bin\\FIBONACCI_DINAMICA_MEMOIZACION.exe");
                if (programa == 5)
                    System.Diagnostics.Process.Start("bin\\PAII_Proyecto5.exe");
                if (programa == 6)
                    System.Diagnostics.Process.Start("bin\\ProyecMochila.exe");
            }
        }

        private void ACOMODAR()
        {
            if (animacion == 0)
            {
                for (int i = 240; i >= 0; i -= 20)
                {
                    Application.DoEvents();
                    Thread.Sleep(10);
                    WRAPPER.Location = new Point(i, 50);
                }
            }            

            if (animacion == 0)
            {
                for (int i = 1300; i >= 810; i -=30)
                {
                    Application.DoEvents();
                    Thread.Sleep(5);
                    SIDEWRAPPER.Location = new Point(i, 50);
                }
            }

            animacion = 1;
        }

        private void BtnINSTALARFUENTES_Click(object sender, EventArgs e)
        {
            string installerFilePath;
            try
            {
                installerFilePath = "install\\ArabDances.ttf";
                System.Diagnostics.Process installerProcess;
                installerProcess = System.Diagnostics.Process.Start(installerFilePath, "/q");
                while (installerProcess.HasExited == false)
                {
                    //indicate progress to user 
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(250);
                }
            }
            catch { }
            try
            {
                installerFilePath = "install\\ArabianKnigth.ttf";
                System.Diagnostics.Process installerProcess;
                installerProcess = System.Diagnostics.Process.Start(installerFilePath, "/q");
                while (installerProcess.HasExited == false)
                {
                    //indicate progress to user 
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(250);
                }
            }
            catch { }
            try
            {
                installerFilePath = "install\\KoheletRegular.ttf";
                System.Diagnostics.Process installerProcess;
                installerProcess = System.Diagnostics.Process.Start(installerFilePath, "/q");
                while (installerProcess.HasExited == false)
                {
                    //indicate progress to user 
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(250);
                }
            }
            catch { }
            try
            {
                installerFilePath = "install\\Poppins-Light.ttf";
                System.Diagnostics.Process installerProcess;
                installerProcess = System.Diagnostics.Process.Start(installerFilePath, "/q");
                while (installerProcess.HasExited == false)
                {
                    //indicate progress to user 
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(250);
                }
            }
            catch { }
            try
            {
                installerFilePath = "install\\Poppins-Medium.ttf";
                System.Diagnostics.Process installerProcess;
                installerProcess = System.Diagnostics.Process.Start(installerFilePath, "/q");
                while (installerProcess.HasExited == false)
                {
                    //indicate progress to user 
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(250);
                }
            }
            catch { }
            try
            {
                installerFilePath = "install\\Poppins-Regular.ttf";
                System.Diagnostics.Process installerProcess;
                installerProcess = System.Diagnostics.Process.Start(installerFilePath, "/q");            while (installerProcess.HasExited == false)
            {
                //indicate progress to user 
                Application.DoEvents();
                System.Threading.Thread.Sleep(250);
            }
                while (installerProcess.HasExited == false)
                {
                    //indicate progress to user 
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(250);
                }
            }
            catch { }
            try
            {
                installerFilePath = "install\\Poppins-SemiBold.ttf";
                System.Diagnostics.Process installerProcess;
                installerProcess = System.Diagnostics.Process.Start(installerFilePath, "/q");
                while (installerProcess.HasExited == false)
                {
                    //indicate progress to user 
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(250);
                }
            }
            catch { }
            try
            {
                installerFilePath = "install\\Sayonara Beveled Free.ttf";
                System.Diagnostics.Process installerProcess;
                installerProcess = System.Diagnostics.Process.Start(installerFilePath, "/q");
                while (installerProcess.HasExited == false)
                {
                    //indicate progress to user 
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(250);
                }
            }
            catch { }
            try
            {
                installerFilePath = "install\\Taibaijan.ttf";
                System.Diagnostics.Process installerProcess;
                installerProcess = System.Diagnostics.Process.Start(installerFilePath, "/q");
                while (installerProcess.HasExited == false)
                {
                    //indicate progress to user 
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(250);
                }
            }
            catch { }

            MessageBox.Show("INSTALACION FINALIZADA");
        }
    }
}
