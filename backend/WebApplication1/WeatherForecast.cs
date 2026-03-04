namespace WebApplication1
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        //chnages in The dev2 now take pull    from the dev1 and then merge to the main branch
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        // dev branch chnages in The dev1 folder for the merge conflict 
    }
}
