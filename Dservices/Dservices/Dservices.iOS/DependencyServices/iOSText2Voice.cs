using AVFoundation;
using Dservices.DependencyServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dservices.iOS.DependencyServices
{
    public class iOSText2Voice : IText2Voice
    {
       

        public void speak(string text)
        {
            var speechSinthesizer = new AVSpeechSynthesizer();
            var speechUterance = new AVSpeechUtterance(text) {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("es-ES"),
                Volume = 0.5F,
                PitchMultiplier = 1.0F              

            };
            speechSinthesizer.SpeakUtterance(speechUterance);
        }
    }
}
