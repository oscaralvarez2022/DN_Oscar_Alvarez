﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AudioManager
{
    public class Train : Transport
    {
        public override void MakeSound()
        {
            Console.WriteLine("Train Sound");

            AudioFileReader audioFile = new AudioFileReader("Resources/train.mp3");
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
