namespace MovieStar
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal class Program
    {
        private const string DataPath = @"C:\...\Task 1";

        internal static void Main()
        {
            var data = File.ReadAllText($"{DataPath}/input.txt");

            var movieStarsDtos = JsonConvert.DeserializeObject<IEnumerable<DataTransferObject>>(data);
            foreach (var dto in movieStarsDtos)
            {
                var movieStar = new MovieStar
                {
                    FullName = dto.Name + " " + dto.Surname,
                    Sex = dto.Sex,
                    Nationality = dto.Nationality,
                    Age = CalculateAge(dto.DateOfBirth),
                };

                Console.WriteLine(movieStar.FullName + "\n" +
                    movieStar.Sex + "\n" +
                    movieStar.Nationality + "\n" +
                    movieStar.Age + " years old" + "\n");
            }
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var age = today.Year - dateOfBirth.Year;

            return age;
        }
    }
}
