using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;

namespace Most_Useless_Assembly_Ever
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Game.OnUpdate += a =>
            {
                Slack();
            };
        }

        public static void Slack()
        {
                //IM NOT DOING ANYTHIN AT ALL LOL
        }
    }
}
