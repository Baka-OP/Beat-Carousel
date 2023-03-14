using System.Numerics;
using Beat_Carousel;
using Raylib_cs;

namespace Beat_Carousel.LevelEntities
{
    public class Node
    {
        Vector2 position;
        Color inner_color;
        Color outer_color;
        Sizes sizes;

        public Node(Vector2 pos, Color inner_color, Color outer_color)
        {
            this.position = pos;
            this.inner_color = inner_color;
            this.outer_color = outer_color;

            sizes = new Sizes();
        }

        void Draw()
        {
            
        }
    }
}