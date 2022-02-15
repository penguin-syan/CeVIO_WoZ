using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CeVIO.Talk.RemoteService2;

namespace CeVIO_WoZ
{
    class CeVIO
    {
        public static void playCeVIO(string talkText)
        {
            //CeVIO AIを起動
            ServiceControl2.StartHost(false);

            //小春六花がしゃべるための設定
            Talker2 talker = new Talker2();
            talker.Cast = "小春六花";
            talker.Volume = 50;
            talker.Speed = 50;
            talker.Tone = 50;
            talker.Alpha = 50;
            talker.ToneScale = 50;

            //感情値設定
            talker.Components["嬉しい"].Value = 0;
            talker.Components["普通"].Value = 100;
            talker.Components["怒り"].Value = 0;
            talker.Components["哀しみ"].Value = 0;
            talker.Components["落ち着き"].Value = 0;

            SpeakingState2 state = talker.Speak(talkText);
        }


        public static void createCeVIOAudio(string talkText, string fileName)
        {
            //指定場所にフォルダがない場合，作成
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CeVIO_WoZ";
            if (!System.IO.Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            //CeVIO AIを起動
            ServiceControl2.StartHost(false);

            //小春六花がしゃべるための設定
            Talker2 talker = new Talker2();
            talker.Cast = "小春六花";
            talker.Volume = 50;
            talker.Speed = 50;
            talker.Tone = 50;
            talker.Alpha = 50;
            talker.ToneScale = 50;

            //感情値設定
            talker.Components["嬉しい"].Value = 0;
            talker.Components["普通"].Value = 100;
            talker.Components["怒り"].Value = 0;
            talker.Components["哀しみ"].Value = 0;
            talker.Components["落ち着き"].Value = 0;

            talker.OutputWaveToFile(talkText, @folder + fileName);
        }
    }
}
