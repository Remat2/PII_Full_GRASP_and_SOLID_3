using System;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Los objetos de este tipo son capaces de imprimir un recipe.
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// Imprime el recipe.
        /// </summary>
        /// <param name="recipe">El recipe a imprimir.</param>
        void PrintRecipe(Recipe recipe);
    }
}