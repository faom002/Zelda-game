using Raylib_cs;
using System.Numerics;

namespace Game
{
    public class GoronNpcComponent : Component
    {

        private int spriteHeight;
        private int spriteWidth;

        private Texture2D character;

        private int frameX = 0;
        private int frameY = 0;

        private int positionNpcX;
        private int positionNpcY;



        private Vector2 position;



      
        private float frameCounter = 0;
        private const float frameSpeed = 2.0f; // Frames per second




        public GoronNpcComponent(string imagePath, int spriteHeight, int spriteWidth, int positionNpcX, int positionNpcY) {
            character = Raylib.LoadTexture(imagePath);
            this.spriteWidth = spriteWidth;
            this.spriteHeight = spriteHeight;
            this.positionNpcX = positionNpcX; 
            this.positionNpcY = positionNpcY;
        }


        public Rectangle npcGoron()
        {
            return new Rectangle(spriteWidth * frameX, spriteHeight * frameY, spriteWidth, spriteHeight);

        }


        public Rectangle getNpcsRec ()
        {
            return  new Rectangle(position.X, position.Y, spriteWidth, spriteHeight);

        }



        public override void Draw()
        {
            Collision collision = new Collision();
           moveAnimation();

            // Define the source rectangle from the sprite sheet.

            // Define the position to draw the sprite on the screen.
             position = new Vector2(500 / 2 + positionNpcX, 380 / 2 + positionNpcY);


            Raylib.DrawRectangleLinesEx(getNpcsRec(), 2, Color.Red);


            // Draw the part of the texture defined by sourceRectangle at the position on the screen.
            Raylib.DrawTextureRec(character, npcGoron(), position, Color.White);

        }

        private void moveAnimation()
        {
            frameCounter += Raylib.GetFrameTime();
            if (frameCounter >= 1.0f / frameSpeed)
            {
                frameCounter = 0;
                frameX++;
                if (frameX > 1) frameX = 0;
            }
        }

    }
}
