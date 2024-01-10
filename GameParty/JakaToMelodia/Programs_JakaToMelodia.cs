using NAudio.Wave;
using System;
using System.Windows;

namespace GameParty
{
    
    internal class Programs_JakaToMelodia
    {
        AudioFileReader audioFileReader;
        IWavePlayer waveOutDevice = new WaveOut();
        public void PlayMusic(string fileName)
        {
            

            try
            {
                CloseWaveOut();
                waveOutDevice = new NAudio.Wave.WaveOut();
                audioFileReader = new NAudio.Wave.AudioFileReader(fileName);
                audioFileReader.CurrentTime = new TimeSpan(0, 0, 8);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Wystąpił błąd: {0}", ex.Message));
            }
        }
        private void CloseWaveOut()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
        }
    }
}
