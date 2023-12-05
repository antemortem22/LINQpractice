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
                var directoresSinPeliculas = context.Directores
                                            .Where(director => !context.Peliculas.Any(pelicula => pelicula.IdDirector == director.IdDirector))
                                            .Select(director => director);

                Console.WriteLine("Directores sin peliculas:");
                foreach (var director in directoresSinPeliculas)
                {
                    Console.WriteLine($"{director.Nombre} no tiene peliculas asignadas");
                }
            }

            /*2. listar productoras sin peliculas, mostrar nombre de productora */
            using (var context = new PeliculasDbContext(options))
            {
                var productorasSinPeliculas = context.Productoras
                                            .Where(productora => !context.Peliculas.Any(pelicula => pelicula.IdProductora == productora.IdProductora))
                                            .GroupBy(productora => productora.Nombre)
                                            .Select(group => new
                                            {
                                                Nombre = group.Key,

                                            });
                                            



                Console.WriteLine("\n ///////////////////////////////////////////");
                Console.WriteLine("Productoras sin películas:");
                foreach (var productora in productorasSinPeliculas)
                {
                    Console.WriteLine($"La productora \"{productora.Nombre}\" no tiene películas asignadas");
                }
            }

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
