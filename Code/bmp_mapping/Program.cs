using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FileManipulation.Framework;

namespace bmp_mapping
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = "";
            string x;
            Console.Write("Nome da imagem: ");
            x = Console.ReadLine();
            //x = "teste.bmp";
            using (Bitmap bmp = new Bitmap(x))
            {
                Console.WriteLine("Largura: " + bmp.Width);
                Console.WriteLine("Altura: " + bmp.Height);

                arquivo += "<!DOCTYPE html>\n";
                arquivo += "<html>\n";
                arquivo += "<head>\n";
                arquivo += "<style>\n";
                arquivo += "td{\n";
                //arquivo += "width: 1px;\n";
                //arquivo += "height: 1px;\n";
                arquivo += "width: 0.01px;\n";
                arquivo += "height: 0.01px;\n";
                arquivo += "}\n";
                arquivo += "table, tr, td{\n";
                arquivo += "border-spacing: 0px;\n";
                arquivo += "}\n";
                arquivo += "</style>\n";
                arquivo += "</head>\n";
                arquivo += "<body>\n";
                arquivo += "</body>\n";
                arquivo += "<table>\n";
                for (int i = 0; i < bmp.Height; i++)
                {
                    arquivo += "    <tr>\n";
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        Color clr = bmp.GetPixel(j, i);
                        int red = clr.R;
                        int green = clr.G;
                        int blue = clr.B;


                        arquivo +=
                            "       <td bgcolor=\"#" +
                            Convert.ToString(red, 16).PadLeft(2, '0') +
                            Convert.ToString(green, 16).PadLeft(2, '0') +
                            Convert.ToString(blue, 16).PadLeft(2, '0') + "\">" +
                            "</td>\n";

                    }
                    arquivo += "    </tr>\n";

                }
                arquivo += "</table>\n";
                arquivo += "</body>\n";
                arquivo += "</html>\n";


            }
            new WriteFile(arquivo.Split('\n'), x, "htm");
            Console.WriteLine("Concluído");
            Console.ReadKey();
        }
    }
}
