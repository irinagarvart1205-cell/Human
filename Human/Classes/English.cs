using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.Classes
{
    public class English : Human
    {
        private List<Phrase> Phrases { get; set; }
        private int stepAudio;
        private int StepAudio
        {
            get { return stepAudio; }
            set
            {
                stepAudio = value;
                if (stepAudio > Phrases.Count - 1)
                    stepAudio = 0;
            }
        }
        public English(string Name, string Img) : base(Name, Img)
        {
            this.Phrases = AllPhrases();
        }
        public override void Speak(System.Windows.Controls.Label Phrase)
        {
            Phrase.Content = Phrases[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(Phrases[StepAudio].Src));
            MainWindow.MediaPlayer.Play();
            StepAudio++;
        }
        public static List<Phrase> AllPhrases()
        {
            List<Phrase> allPhrases = new List<Phrase>();
            allPhrases.Add(new Phrase("Hello", @"C:\\Users\\Student-A502.PERMAVIAT\\Desktop\\Human\\Human\\Voices\\Voice4.mp3"));
            allPhrases.Add(new Phrase("How are you", @"C:\\Users\\Student-A502.PERMAVIAT\\Desktop\\Human\\Human\\Voices\\Voice5.mp3"));
            allPhrases.Add(new Phrase("My nemt is Irina", @"C:\\Users\\Student-A502.PERMAVIAT\\Desktop\\Human\\Human\\Voices\\Voice6.mp3"));
            return allPhrases;
        }
    }
}
