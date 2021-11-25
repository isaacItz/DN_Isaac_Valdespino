using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioManager
{
    public class Cow : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("I'm a Cow");
            AudioFileReader adf = new AudioFileReader("Resources/cow.wav");
            WaveOutEvent waveEvent = new WaveOutEvent();

            waveEvent.Init(adf);
            waveEvent.Play();
            Console.WriteLine("Reproduciendo Sonido");
            while (waveEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }
            adf.Dispose();
            waveEvent.Dispose();
        }
    }
}
