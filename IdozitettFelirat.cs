namespace E17M230302
{
    internal class IdozitettFelirat
    {
        public string Idozites { get; set; }
        public string Felirat { get; set; }
        public string SrtIdozites
        {
            get 
            {
                var ti = Idozites.Split(" - ");

                var top = ti[0].Split(':');
                TimeSpan tol = new(
                    hours: 0,
                    minutes: int.Parse(top[0]),
                    seconds: int.Parse(top[1]));

                var iop = ti[1].Split(':');
                TimeSpan ig = new(
                    hours: 0,
                    minutes: int.Parse(iop[0]),
                    seconds: int.Parse(iop[1]));

                return $"{tol} --> {ig}";
            }
        }


        public int SzavakSzama => Felirat.Split().Length;

        public IdozitettFelirat(string idozites, string felirat)
        {
            Idozites = idozites;
            Felirat = felirat;
        }
    }
}
