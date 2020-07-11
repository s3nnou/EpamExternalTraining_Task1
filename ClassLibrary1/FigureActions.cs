using FiguresClassLibrary;
using System.Linq;

namespace FiguresLibrary
{
    public class FigureActions
    {
        /// <summary>
        /// Finds all duplicate array members as given figures class child
        /// uses linq query and childs class equal method
        /// </summary>
        /// <param name="figureToFind"></param>
        /// <param name="arrayForSearch"></param>
        /// <returns>array of duplicates</returns>
        public Figure[] GetSameFiguresArray(Figure figureToFind, Figure[] arrayForSearch)
        {
            var query = (from fig in arrayForSearch
                         where fig.Equals(figureToFind)
                         select fig).ToArray();

            return query;
        }
    }
}
