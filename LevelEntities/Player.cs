using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Raymath;

namespace Beat_Carousel.LevelEntities{
    public class Player{

        private float inner_Radius;
        private Color inner_color;

        private float outer_Radius;
        private Color outer_color;

        private Vector2 position;
        public int Direction;
        public float Speed;
        public float RotationRadius;

        private float _Rotateangle;

        private int windowWidth;
        private int windowHeight;
        
        public Player(int width, int height, float inner_radius, Color inner_color, float outer_radius, Color outer_color, float rotation_radius, float speed){

            this.windowWidth = width;
            this.windowHeight = height;

            //setup the inner circle
            this.inner_Radius = inner_radius;
            this.inner_color = inner_color;
            //setup the outer circle
            this.outer_Radius = outer_radius;
            this.outer_color = outer_color;

            this.RotationRadius = rotation_radius;
            this.Speed = speed;
            this.position = new Vector2(0f, rotation_radius);
            this.Direction = 1;
        }

        public void Draw()
        {
            Raylib.DrawCircleV(position, outer_Radius, outer_color);
            Raylib.DrawCircleV(position, inner_Radius, inner_color);
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