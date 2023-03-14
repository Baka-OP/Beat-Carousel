using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Raymath;

namespace Beat_Carousel.LevelEntities{
    public class Player{

        private Color inner_color;

        private Color outer_color;

        private Vector2 position;
        public int Direction;
        public float Speed;
        public float RotationRadius;

        private float _Rotateangle;

        private int windowWidth;
        private int windowHeight;
        
        Sizes sizes;

        public Player(int width, int height, Color inner_color, Color outer_color, float rotation_radius, float speed){

            this.windowWidth = width;
            this.windowHeight = height;

            //setup the inner circle
            this.inner_color = inner_color;
            //setup the outer circle
            this.outer_color = outer_color;

            this.RotationRadius = rotation_radius;
            this.Speed = speed;
            this.position = new Vector2(0f, rotation_radius);
            this.Direction = 1;

            sizes = new Sizes();
        }

        public void Draw()
        {
            Raylib.DrawCircleV(position, sizes.player_outer_radius, outer_color);
            Raylib.DrawCircleV(position, sizes.player_inner_radius, inner_color);
        }

        public void Rotate()
        {
            _Rotateangle += Speed * Raylib.GetFrameTime() * Direction;
            Vector2 rotatedPosition = new Vector2(MathF.Sin(_Rotateangle), MathF.Cos(_Rotateangle)) * RotationRadius;
            Vector2 offset = new Vector2(windowWidth/2, windowHeight/2);
            position = rotatedPosition + offset;
        }
        public void Flip() => Direction *= -1;
    }
}