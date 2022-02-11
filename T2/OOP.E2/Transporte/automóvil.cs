using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Transporte
{
    public class automóvil:vehículo
    {
        public override void hacerSonido()
        {
            Console.WriteLine("Reproduciendo Sonido de Automóvil...");

            AudioFileReader audioFile = new AudioFileReader("Resources/automóvil.mp3");
            WaveOutEvent waveOutEvent = new WaveOutEvent();

            waveOutEvent.Init(audioFile);
            waveOutEvent.Play();

            while (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }

            waveOutEvent.Dispose();
            audioFile.Dispose();
        }
    }
}
