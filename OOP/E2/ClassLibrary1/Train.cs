using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Train : Vehicle
    {
        public override void MakeASound()
        {
            AudioFileReader audioFileReader = new AudioFileReader("Resources/tren.mp3");
            WaveOutEvent waveEvent = new WaveOutEvent();

            waveEvent.Init(audioFileReader);
            waveEvent.Play();
            while (waveEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }
            audioFileReader.Dispose();
            waveEvent.Dispose();
        }
    }
}
