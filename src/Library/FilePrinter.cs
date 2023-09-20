using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Esta clase representa una impresora que imprime un recipe en un archivo de texto.
    /// </summary>
    public class FilePrinter : IPrinter
    {
        /// <summary>
        /// Imprime el recipe a un archivo.
        /// </summary>
        /// <param name="recipe">El recipe a imprimir.</param>
        public void PrintRecipe(Recipe recipe)
        {
            if (recipe != null)
            {
                File.WriteAllText("Ticket.txt", recipe.GetTextToPrint());
            }
        }
    }
}