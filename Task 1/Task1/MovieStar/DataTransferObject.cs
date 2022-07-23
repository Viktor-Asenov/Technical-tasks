namespace MovieStar
{
    using System;

    internal class DataTransferObject : Person
    {
        public DateTime DateOfBirth { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}