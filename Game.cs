using Raylib_cs;
using Beat_Carousel.LevelEntities;

namespace Beat_Carousel{
    public class Game{
        
        private int width;
        private int height;
        private string label;

        public Center center;
        public Player player;
        public Node node;

        Sizes sizes;

        public Game(int width, int height, string label){
            this.width = width;
            this.height = height;
            this.label = label;

            sizes = new Sizes();
        }
        
        public void Start()
        {
            // init window
            Raylib.InitWindow(width, height, label);

            // init the level entities. for now we init them with the window but 
            // scenes system will be implemented soon.

            center = new Center(width, height, Color.BLACK, Color.RED);
            player = new Player(width, height, Color.BLACK, Color.GREEN, sizes.player_rotation_radius, 1f);
            node = new Node(0, Color.BLACK, Color.SKYBLUE);

            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKGRAY);

                Raylib.DrawText(Raylib.GetFPS().ToString(), 0, 0, 20, Color.WHITE);

                Raylib.DrawCircleLines(width/2, height/2, sizes.player_rotation_radius, Color.RED);

                DrawObjects();
                player.Rotate();
                
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)){
                    player.Flip();
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT_SHIFT))
                {
                    node.angle_position += 10f;
                }

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }

        public void DrawObjects()
        {
            center.Draw();
            player.Draw();
            node.Draw();
        }

    }
}