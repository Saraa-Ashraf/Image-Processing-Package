using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CsharpGUI
{
    public partial class Remove_Noise_form : Form
    {
        [DllImport("Project.dll")]
        private static extern void computeConst(int width, int height, int border);

        [DllImport("Project.dll")]
        private static extern int getWindow([In] int[] pixelArray, [In, Out] int[] resultArray);


        public int[] red_color_3_RE;
        public int[] blue_color_3_RE;
        public int[] green_color_3_RE;

        public int[] redArrayResult;
        public int[] blueArrayResult;
        public int[] greenArrayResult;

        int width, height;
        Bitmap imageBorders;
        Bitmap resultImage;
        public Remove_Noise_form(Bitmap bitmap3, Color[] color3, int border, Image imageB)
        {
            InitializeComponent();

            width = bitmap3.Width;
            height = bitmap3.Height;

            

            int size_3 = color3.Length;
            red_color_3_RE = new int[size_3];
            blue_color_3_RE = new int[size_3];
            green_color_3_RE = new int[size_3];
            for (int i = 0; i < color3.Length; i++)
            {
                red_color_3_RE[i] = color3[i].R;
                blue_color_3_RE[i] = color3[i].B;
                green_color_3_RE[i] = color3[i].G;
            }

            redArrayResult = new int[size_3];
            greenArrayResult = new int[size_3];
            blueArrayResult = new int[size_3];


            computeConst(width, height, border);

            getWindow(red_color_3_RE, redArrayResult);
            getWindow(green_color_3_RE, greenArrayResult);
            getWindow(blue_color_3_RE, blueArrayResult);

            int index = border / 2;
            
            Color[] newPixels = new Color[size_3];
            int count = 0;
            imageBorders = new Bitmap(width, height);
            
            count = 0;

            for (int i = 0; i < imageBorders.Width; i++)
            {
                for (int j = 0; j < imageBorders.Height; j++) 
                {
                    imageBorders.SetPixel(i, j, Color.FromArgb(redArrayResult[count], greenArrayResult[count], blueArrayResult[count]));
                    count++;
                }
            }
            
            resultImage = new Bitmap(imageB.Width - index, imageB.Height - index);


            for (int i = index; i < resultImage.Width - (2*index); i++)
            {
                for (int j = index; j < resultImage.Height - (2*index); j++)
                {
                    resultImage.SetPixel(i - index, j-index, imageBorders.GetPixel(i + index , j + index));
                    
                }
                
            }
            
            pictureBox1.Image = resultImage;
        }

        private void Remove_Noise_form_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(sfd.FileName))
                {
                    System.IO.File.Delete(sfd.FileName);
                }
                resultImage.Save(sfd.FileName);
                MessageBox.Show("Image Saved!");
            }
        }
    }
}
