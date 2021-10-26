using System;

public class Car
{
	public Car ()
	{


    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }


    public Car(string Make, string Model, int Year, decimal Price)
    {
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
        this.Price = Price;
    }


    //public virtual void PrintInfo(Movie movie)
    //{
    //    Console.WriteLine("");
    //    string response = $"Title: {movie.Title}\n";
    //    response += $"Category: {movie.Category}\n";
    //    response += $"Genre: {movie.Genre}\n";
    //    response += $"Runtime: {movie.Runtime}";
    //    Console.WriteLine(response);
    //}

}
}
