using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace salvar_imagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string arquivo, caminhoarquivo;
        private void btnAddImagem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             
            
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            picturebox.Image.Save("D:\\fotos\\" + arquivo + ".png", System.Drawing.Imaging.ImageFormat.Png);
            string dbfile = carregarfoto.FileName;


        }

        private void ptBImagem_Click(object sender, EventArgs e)
        {
            try
            {
                carregarfoto.ShowDialog();
                Bitmap bmp = new Bitmap(carregarfoto.FileName);

                Bitmap bmp2 = new Bitmap(bmp);
                picturebox.Image = bmp2;
                string nomeArquivo = Path.GetFileNameWithoutExtension(carregarfoto.FileName);

                arquivo = nomeArquivo;
                
                caminhoarquivo = ("D:\\fotos\\" + arquivo + ".png");
              i._caminho = caminhoarquivo.Replace(@"\", @"\\"); ;
                   i.inserir();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar.");
            }

        }
    }
    }




