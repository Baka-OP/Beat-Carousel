using Raylib_cs;
using Beat_Carousel.LevelEntities;

namespace Beat_Carousel{
    public class Game{
        
        private int width;
        private int height;
        private string label;

        public Center center;
        public Player player;

        public Game(int width, int height, string label){
            this.width = width;
            this.height = height;
            this.label = label;
        }
        
        public void Start()
        {
            // init window
            Raylib.InitWindow(width, height, label);

            // init the level entities. for now we init them with the window but 
            // scenes system will be implemented soon.

            center = new Center(width, height, ((width + height)/2) * 0.17f, Color.BLACK,
                                ((width + height)/2) * 0.18f, Color.RED);
            player = new Player(width, height, ((width + height)/2) * 0.035f, Color.BLACK,
                                ((width + height)/2) * 0.04f, Color.GREEN, 
                                ((width + height)/2) * 0.28f, 1f);

            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKGRAY);

                Raylib.DrawText(Raylib.GetFPS().ToString(), 0, 0, 20, Color.WHITE);

                DrawObjects();
                player.Rotate();

                if(Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)){
                    player.Flip();
                }

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }

        public void DrawObjects()
        {
            center.Draw();
            player.Draw();
        }

    }
}