using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        public HomeTheaterFacade(
        DvdPlayer dvdPlayer,
        Amplifier amplifier,
        CdPlayer cdPlayer,
        LawOfDementer lawOfDementer,
        PopcornPopper popcornPopper,
        Projector projector,
        Screen screen,
        TheaterLights theaterLights,
        Tuner tuner
        )
        {
            this.DvdPlayer = dvdPlayer;
            this.Amplifier = amplifier;
            this.CdPlayer = cdPlayer;
            this.LawOfDementer = lawOfDementer;
            this.PopcornPopper = popcornPopper;
            this.Projector = projector;
            this.Screen = screen;
            this.TheaterLights = theaterLights;
            this.Tuner = tuner;

        }

        public DvdPlayer DvdPlayer { get; private set; }
        public Amplifier Amplifier { get; private set; }
        public CdPlayer CdPlayer { get; private set; }
        public LawOfDementer LawOfDementer { get; private set; }
        public PopcornPopper PopcornPopper { get; private set; }
        public Projector Projector { get; private set; }
        public Screen Screen { get; private set; }
        public TheaterLights TheaterLights { get; private set; }
        public Tuner Tuner { get; private set; }

        public void PlayMovie(String movie)
        {
            PopcornPopper.On();
            PopcornPopper.Pop();

            TheaterLights.Dim(10);

            Screen.Down();

            Projector.On();
            Projector.SetInput(DvdPlayer);
            Projector.WideScreenMode();

            Amplifier.On();
            Amplifier.SetDvd(DvdPlayer);
            Amplifier.SetSurroundSound();
            Amplifier.SetVolume(5);

            DvdPlayer.On();
            DvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            PopcornPopper.Off();
            TheaterLights.On();
            Screen.Up();
            Projector.Off();
            Amplifier.Off();
            DvdPlayer.Off();
        }
    }
}