using System.Net;

namespace VersionChecker
{
/// <summary>
/// This CS will get the program version and the connected Github page.
/// First you need to give a string ID to the GetVersionLink function. Pl.: GetVersionLink(Teszt)
/// If you give the right ID than you can use the public ints and string. Don't call the public ints and string if you not gave the function the string ID.
/// 
/// Example Code:
/// 
/// using VersionChecker;
/// VersionCheck vs = new VersionCheck();
/// vs.GetVersionLink("Test");
/// Console.WriteLine(vs.MainVersion.ToString() + vs.SubVersion.ToString() + vs.Program_Link);
/// 
/// </summary>

    class VersionCheck
    {
        public int MainVersion,SubVersion=0;
        public string Program_Link="";
        public void GetVersionLink(string Program_ID) 
        {
            string PastebinLink = "https://pastebin.com/raw/vgpT0guy";

            WebClient web = new WebClient();
            string FullString = web.DownloadString(PastebinLink);

            int ID_Index = FullString.IndexOf(Program_ID);

            string ID_Line = FullString.Substring(ID_Index);
            
            string[] Contents = ID_Line.Split(';');

            MainVersion = int.Parse(Contents[1]);
            SubVersion = int.Parse(Contents[2]);
            Program_Link = Contents[3];
        }  
        
    }
}

