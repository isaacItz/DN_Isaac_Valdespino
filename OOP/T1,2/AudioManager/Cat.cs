using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AudioManager
{
    public class Cat : Animal
    {
        public override void AnimalSound()
        {
            AudioFileReader adf = new AudioFileReader("Resources/cat.wav");
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
