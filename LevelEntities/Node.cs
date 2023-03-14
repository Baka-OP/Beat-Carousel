using System.Numerics;
using Beat_Carousel;
using Raylib_cs;

namespace Beat_Carousel.LevelEntities
{
    public class Node
    {
        public float angle_position;
        Color inner_color;
        Color outer_color;
        Sizes sizes;

        Vector2 position;

        public Node(float anglepos, Color inner_color, Color outer_color)
        {
            this.angle_position = anglepos;
            this.inner_color = inner_color;
            this.outer_color = outer_color;

            sizes = new Sizes();
        }

        public void Draw()
        {
            Raylib.DrawCircleV(position, sizes.node_outer_radius, outer_color);
            Raylib.DrawCircleV(position, sizes.node_inner_radius, inner_color);
        }

        void SetPosition()
        {
            Vector2 rotatedPosition = new Vector2(MathF.Sin(angle_position), MathF.Cos(angle_position)) * sizes.player_rotation_radius;
            //HARDCODED THE WINDOW SIZES FOR NOW BECAUSE I AM IRRITATED
            Vector2 offset = new Vector2(800/2, 600/2);
            position = rotatedPosition + offset;
        }
    }
}