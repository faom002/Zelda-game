
using Raylib_cs;
using System.Numerics;

namespace Game
{
    public class Collision
    {
        private Rectangle player;
        private Rectangle npcs;


      
        public void setNpcs(Rectangle npcs)
        {
            this.npcs = npcs;
        }

        public void setPlayer(Rectangle player)
        {
            this.player = player;
        }

        public Rectangle getPlayer()
        {
            return this.player;
        }

        public Rectangle getNpcs()
        {
            return this.npcs;
        }


       



        public void Update()
        {


            if (Raylib.CheckCollisionRecs(getPlayer(),getNpcs()))
                {



                Raylib.DrawText("collision", 0, 0, 10, Color.Red);




            }
        }
    }
}
