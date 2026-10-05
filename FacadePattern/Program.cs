namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);
            LawOfDementer lawOfDementer = new LawOfDementer();

            HomeTheaterFacade theaterFacade = new HomeTheaterFacade(dvdPlayer, amp, cdPlayer, lawOfDementer, popcornPopper, projector, screen, lights, tuner);

            theaterFacade.PlayMovie("Die Hard");

            theaterFacade.EndMovie();
        }
    }
}