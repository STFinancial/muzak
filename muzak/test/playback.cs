//using NAudio.Wave;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading;

//namespace muzak.test
//{
//    class playback
//    {
//        void Thing()
//        {
//            using (var audioFile = new AudioFileReader(@"G:\\Code\muzak\muzak\youGotmail.wav"))
//            using(var outputDevice = new WaveOutEvent())
//            {
//                outputDevice.Init(audioFile);
//                outputDevice.Play();
//                while (outputDevice.PlaybackState == PlaybackState.Playing)
//                {
//                    Thread.Sleep(1000);
//                }
//            }
//        }


//        static void Main(string[] args)
//        {
//            playback p = new playback();
//            p.Thing();
//        }
//    }

//}
