using Raylib_cs;

namespace Beat_Carousel.LevelEntities{
    public class Center{

        private float inner_Radius;
        private Color inner_color;

        private float outer_Radius;
        private Color outer_color;

        private int windowWidth;
        private int windowHeight;
        
        public Center(int width, int height, float inner_radius, Color inner_color, float outer_radius, Color outer_color){
            //setup the inner circle
            this.inner_Radius = inner_radius;
            this.inner_color = inner_color;
            //setup the outer circle
            this.outer_Radius = outer_radius;
            this.outer_color = outer_color;

            this.windowWidth = width;
            this.windowHeight = height;
        }

        public void Draw()
        {
            Raylib.DrawCircle(windowWidth/2, windowHeight/2, outer_Radius, outer_color);
            Raylib.DrawCircle(windowWidth/2, windowHeight/2, inner_Radius, inner_color);
        }
    }
}