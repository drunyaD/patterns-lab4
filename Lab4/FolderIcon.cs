using System;

namespace Lab4
{
    public class FolderIcon : IIcon
    {
        public void Draw(string foldername)
        {
            Console.WriteLine("Drawing folder icon for {0} file", foldername);
        }
    }
}
