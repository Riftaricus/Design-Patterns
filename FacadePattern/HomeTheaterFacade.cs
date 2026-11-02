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
            this.dvdPlayer = dvdPlayer;
            this.amplifier = amplifier;
            this.cdPlayer = cdPlayer;
            this.lawOfDementer = lawOfDementer;
            this.popcornPopper = popcornPopper;
            this.projector = projector;
            this.screen = screen;
            this.theaterLights = theaterLights;
            this.tuner = tuner;

        }

        private DvdPlayer dvdPlayer;
        private Amplifier amplifier;
        private CdPlayer cdPlayer;
        private LawOfDementer lawOfDementer;
        private PopcornPopper popcornPopper;
        private Projector projector;
        private Screen screen;
        private TheaterLights theaterLights;
        private Tuner tuner;

        public void PlayMovie(String movie)
        {

            popcornPopper.On();
            popcornPopper.Pop();

            theaterLights.Dim(10);

            screen.Down();

            projector.On();
            projector.SetInput(dvdPlayer);
            projector.WideScreenMode();

            amplifier.On();
            amplifier.SetDvd(dvdPlayer);
            amplifier.SetSurroundSound();
            amplifier.SetVolume(5);

            dvdPlayer.On();
            dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            popcornPopper.Off();
            theaterLights.On();
            screen.Up();
            projector.Off();
            amplifier.Off();
            dvdPlayer.Off();
        }
    }
}