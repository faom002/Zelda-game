using Raylib_cs;
using TiledSharp;

namespace Game
{


class Program
{


        public static void Main()
    {

            //collsion
            Collision collision = new Collision();

            Raylib.InitWindow(500, 380, "Zelda Project");

            CharacterComponent charComponent = new CharacterComponent("C:\\Users\\Faisa\\source\\repos\\Zelda\\Zelda\\Assets\\link-sheet.png", 32, 32);
            GoronNpcComponent goronComponent = new GoronNpcComponent("C:\\Users\\Faisa\\source\\repos\\Zelda\\Zelda\\Assets\\goron.png", 24, 20 , 20, 30);
            GoronNpcComponent goronComponent2 = new GoronNpcComponent("C:\\Users\\Faisa\\source\\repos\\Zelda\\Zelda\\Assets\\goron.png", 24, 20 , 10, 10);


            // calling on Entity for attaching different components
            Entity entity = new Entity();


            //attaching components
            entity.Attach("goronNpc",goronComponent);
            entity.Attach("goronNpc2",goronComponent2);
            entity.Attach("playerLink",charComponent);

            //music
            Raylib.InitAudioDevice();
            Music music = Raylib.LoadMusicStream("C:\\Users\\Faisa\\source\\repos\\Zelda\\Zelda\\Assets\\Music\\kokiri.mp3");
            Raylib.PlayMusicStream(music);

            while (!Raylib.WindowShouldClose())
        {

                Raylib.UpdateMusicStream(music);


                collision.setPlayer(charComponent.collisionRecPlayer());
               collision.setNpcs(goronComponent.getNpcsRec());

                collision.Update();
                Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);




               

                entity.Draw();



                Raylib.EndDrawing();
        }

            Raylib.UnloadMusicStream(music);

            Raylib.CloseAudioDevice();
            Raylib.CloseWindow();
    }
}
}
