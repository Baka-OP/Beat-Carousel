using Raylib_cs;

namespace Beat_Carousel.LevelEntities{
    public class Center{

        private Color inner_color;

        private Color outer_color;

        private int windowWidth;
        private int windowHeight;

        Sizes sizes;
        
        public Center(int width, int height, Color inner_color, Color outer_color){
            //setup the inner circle
            this.inner_color = inner_color;
            //setup the outer circle
            this.outer_color = outer_color;

            this.windowWidth = width;
            this.windowHeight = height;
            
            sizes = new Sizes();
        }

        public void Draw()
        {
            Raylib.DrawCircle(windowWidth/2, windowHeight/2, sizes.center_outer_radius, outer_color);
            Raylib.DrawCircle(windowWidth/2, windowHeight/2, sizes.center_inner_radius, inner_color);
        }
    }
}