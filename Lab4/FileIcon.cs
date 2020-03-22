using System;

namespace Lab4
{
    /// <summary>
    /// Represents abstract file icon 
    /// </summary>
    public abstract class FileIcon : IIcon
    {
        /// <summary>
        /// Extention of file
        /// </summary>
        protected string extention;
        /// <summary>
        /// Draws file icon with name of file
        /// </summary>
        /// <param name="name">name of element</param>
        public void Draw(string filename)
        {
            Console.WriteLine("Drawing {0} icon for {1} file", extention, filename);
        }
    }
}
