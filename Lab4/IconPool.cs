using System.Collections.Generic;

namespace Lab4
{
    /// <summary>
    /// Represents pool for files' icons 
    /// </summary>
    public class IconPool
    {
        /// <summary>
        /// Incapsulated dictionary for icons 
        /// </summary>
        Dictionary<string, IIcon> icons = new Dictionary<string, IIcon>();
        /// <summary>
        /// Gets icon by extention with lazy initializtion 
        /// </summary>
        /// <param name="extension">Extention of file which icon need to be got</param>
        public IIcon GetIcon(string extension)
        {
            IIcon icon;
            if (icons.TryGetValue(extension, out icon))
            {
                return icon;
            }
            else
            {
                switch (extension)
                {
                    case "png": 
                        icon = new PngIcon();
                        break;
                    case "txt":
                        icon = new TxtIcon();
                        break;
                    case "pdf":
                        icon = new PdfIcon();
                        break;
                    default:
                        return null;
                }
                icons.Add(extension, icon);
                return icon;
            }
        }
    }
}
