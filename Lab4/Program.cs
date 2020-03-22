using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    /// <summary>
    /// Represents usage of Flyweight pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IconPool pool = new IconPool();
            IIcon icon1 =  pool.GetIcon("pdf");
            IIcon icon2 = pool.GetIcon("txt");
            IIcon icon3 = pool.GetIcon("png");
            IIcon icon4 = pool.GetIcon("png");
            IIcon icon5 = pool.GetIcon("notExistingExtension");
            IIcon icon6 = new FolderIcon();
            icon1.Draw("file1");
            icon2.Draw("file2");
            icon3.Draw("file3");
            icon4.Draw("file4");
            try
            {
                icon5.Draw("file5");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            icon6.Draw("file6");
            Console.Read();
        }
    }
}
