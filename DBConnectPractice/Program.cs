using Microsoft.EntityFrameworkCore;
using static DBConnectPractice.Repository.DBContext;

namespace DBConnectPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringConnection = @"Data Source=localhost;Initial Catalog=IMDB;Integrated Security=True;Trust Server Certificate=True";
            var options = new DbContextOptionsBuilder<PeliculasDbContext>().UseSqlServer(stringConnection).Options;


            /*1. listar directores sin peliculas, mostrar nombre de director  */
            using (var context = new PeliculasDbContext(options))
            {
                var directoresSinPeliculas = from director in context.Directores
                                             where !context.Peliculas.Any(pelicula => pelicula.IdDirector == director.IdDirector)
                                             select director;

                Console.WriteLine("Directores sin peliculas:");
                foreach (var director in directoresSinPeliculas)
                {
                    Console.WriteLine($"{director.Nombre} no tiene peliculas asignadas");
                }
            }

            /*2. listar productoras sin peliculas, mostrar nombre de productora */

            /*3. listar actores agrupados por sexo, mostrar cantidad de actores para cada sexo */

            /*4. listar actores sin actuaciones, mostrar nombre del actor */

            /*5. listar cantidad peliculas por productora con recaudacion total > $300.000.000 */

            /*6. listar los directores con mayor recaudación */

            /* 7.listar los directores con mayor recaudación en los años 80 */

            /* 8.listar las 10 peliculas con mayor ranking*/

            /* 9.listar los directores con 2 o mas peliculas con ranking = 5 */

            /* 10.listar las productoras con su promedio de rankings de peliculas */




        }
    }
}
