using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infosoft_crash_course
{
    public class GameProfile
    {
        public string inGameName;
        public int mmr;
        public string role;
        //class with constructor
        public GameProfile(string inGameName, int mmr, string role)
        {
            this.inGameName = inGameName;
            this.mmr = mmr;
            this.role = role;

            Console.WriteLine("Hello " + inGameName +"\n"+ "Your MMR is: " + mmr +"\n" +"Your Role is: " + role);
        }
    }
}
