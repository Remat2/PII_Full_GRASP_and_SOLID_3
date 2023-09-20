using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Esta clase representa una impresora que imprime un ticket de venta por consola.
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        /// <summary>
        /// Imprime un ticket de venta por consola.
        /// </summary>
        /// <param name="sale">El ticket de venta a imprimir.</param>
        public void PrintRecipe(Recipe recipe)
        {
            if (recipe != null)
            {
                Console.WriteLine(recipe.GetTextToPrint());
            }
        }
    }
}