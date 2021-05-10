using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace CsharpGUI
{
    public partial class Form1 : Form
    {
       public Image image_RE;
       public Bitmap bitmap_RE;
       public Color[] pixels_arr_RE;
       public Color[] re_3_noise_RE;
       //public Color[] re_5_noise_RE;

       int size_RE;
       int border;

        public Form1()
        {
            InitializeComponent();
        }

        private void open_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog_RE = new OpenFileDialog();
            fileDialog_RE.Filter = "All Files|*.*";

            if (fileDialog_RE.ShowDialog() == DialogResult.OK)
            {
                image_RE = Image.FromFile(fileDialog_RE.FileName);
                bitmap_RE = new Bitmap(fileDialog_RE.FileName);
                size_RE = getPixels(bitmap_RE).Length;
                pixels_arr_RE = new Color[size_RE];
                pixels_arr_RE = getPixels(bitmap_RE);
                //re_3_noise_RE = To_Integer_Array(Border_3_Image(bitmap_RE, border));
                //re_5_noise_RE = To_Integer_Array(Border_5_Image(bitmap_RE));
                pictureBox1.Image = image_RE;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open grayscale form

            Grayscale_form grayscale_Form = new Grayscale_form(image_RE, pixels_arr_RE);
            grayscale_Form.ShowDialog();
        }

        private void remove_noise__btn_Click(object sender, EventArgs e)
        {
            
        }

        private void brightness_btn_Click(object sender, EventArgs e)
        {
            //open brightness form
            Brightness_form brightness_Form = new Brightness_form(image_RE, pixels_arr_RE);
            brightness_Form.ShowDialog();
        }


        public static Color[] getPixels(Bitmap bitmap)
        {
            int size = bitmap.Height * bitmap.Width;
            int k = 0;
            Color[] pixels=new Color[size];


               for(int i=0;i<bitmap.Width;i++)
            {
                for(int j=0;j<bitmap.Height;j++)
                {
                    pixels[k]= bitmap.GetPixel(i,j);
                    k++;
                }
            }

            return pixels;
        }
        public static Bitmap borderPadding(Bitmap bitmap, int b)
        {
            int ext = b / 2;
            int H_size = bitmap.Height + (2 * ext);
            int W_size = bitmap.Width + (2 * ext);
            Bitmap rn_bitmap;
            rn_bitmap = new Bitmap(bitmap.Width + (2 * ext), bitmap.Height + (2 * ext));
            Color color = Color.FromArgb(0, 0, 0);

            //set the fist and last b with zeros

            for (int i = 0; i < ext; i++)
            {
                for (int j = 0; j < H_size; j++)
                {
                    rn_bitmap.SetPixel(i, j, color);
                    rn_bitmap.SetPixel(W_size - i - 1, j, color);
                }
            }

            for (int i = 0; i < W_size; i++)
            {
                for (int j = 0; j < ext; j++)
                {
                    rn_bitmap.SetPixel(i, j, color);
                    rn_bitmap.SetPixel(i, H_size - j - 1, color);
                }
            }


            
            for (int i = ext; i < W_size - ext; i++)
            {
                for (int j = ext; j < H_size - ext; j++)
                {
                    rn_bitmap.SetPixel(i, j, bitmap.GetPixel(i - ext, j - ext));
                }
            }
            
            return rn_bitmap;
        }
        
        private void buttonInvertImage_Click(object sender, EventArgs e)
        {
            //open invert colors form
            InvertColors_form invertcolors_Form = new InvertColors_form(image_RE, pixels_arr_RE);
            invertcolors_Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageArithmatic_Form imageArth_form = new ImageArithmatic_Form();
            imageArth_form.ShowDialog();
        }

        private void removeNoise_btn_Click(object sender, EventArgs e)
        {
            
            //remove noise func.            
            border = Convert.ToInt32(textBox_removeNois.Text);
            if (border <= 0 || border > 100)
            {
                MessageBox.Show("Please enter a value between 0 and 100");
            }
            else if (border % 2 == 0)
            {
                MessageBox.Show("please enter an odd number");
            }
            else
            {
                re_3_noise_RE = getPixels(borderPadding(bitmap_RE, border));
                Remove_Noise_form remove_Noise_Form = new Remove_Noise_form(borderPadding(bitmap_RE, border), re_3_noise_RE, border, image_RE);
                remove_Noise_Form.ShowDialog();
            }
        }

        
        
        
    }
}
