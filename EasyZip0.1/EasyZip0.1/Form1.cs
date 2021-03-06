﻿//EasyZip0.2 Desarrollado Por Enoc Carrera
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace EasyZip0._1
{
    public partial class Form1 : MetroSetForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Escoge Tu Ruta.";
            if (fbd.ShowDialog() == DialogResult.OK)
                textFolder.Text = fbd.SelectedPath;
        }

        private void buttonArchivo_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter="Todos los Archivos|*.*", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    textArchivo.Text = ofd.FileName;
            }
        }

        private void buttonZIPFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFolder.Text))
            {
                MessageBox.Show("Por Favor Seleccione un Folder.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textFolder.Focus();
                return;
            }
            string Ruta = textFolder.Text;
            Thread thread = new Thread(t =>
              {
                  using(Ionic.Zip.ZipFile zip=new Ionic.Zip.ZipFile())
                  {
                      zip.AddDirectory(Ruta);
                      System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Ruta);
                      zip.SaveProgress += Zip_SaveProgress;
                      zip.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, di.Name));
                  }
              })
            { IsBackground = true };
            thread.Start();
        }

        private void Zip_SaveProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar1.Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Maximum = e.EntriesTotal;
                    progressBar1.Value = e.EntriesSaved + 1;
                    progressBar1.Update();
                }));
            }
        }

        private void Zip_SaveFileProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBar1.Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Maximum = 100;
                    progressBar1.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar1.Update();
                }));
            }
        }

        private void buttonZIPArchivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textArchivo.Text))
            {
                MessageBox.Show("Por Favor Seleccione un Archivo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textArchivo.Focus();
                return;
            }
            string NombreArch = textArchivo.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    FileInfo fi = new FileInfo(NombreArch);
                    zip.AddFile(NombreArch);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(NombreArch);
                    zip.SaveProgress += Zip_SaveFileProgress;
                    zip.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, di.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnZIPfolder_Click(object sender, EventArgs e)
        {
            //string Ruta = Path.GetFullPath(textFolder.Text);
            string RutaZip = @"C:\Users\sentr\Desktop\Ejemplo.zip";
            string RutaExtracion = textFolder.Text;
            //Advertencia por si se deja en blanco la ruta del Folder
            // if (string.IsNullOrEmpty(textFolder.Text))
            //  {
            //      MessageBox.Show("Por Favor Seleccione un Folder para Descomprimir.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //     textFolder.Focus();
            //     return;
            ZipFile.ExtractToDirectory(RutaZip, RutaExtracion);
        }
           // if (!Ruta.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal))
              //  Ruta += Path.DirectorySeparatorChar;
              
        }






    }
    

