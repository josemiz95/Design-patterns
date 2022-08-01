namespace Bridge
{
    public abstract class Shape
    {
        protected IRenderer renderer;

        public Shape(IRenderer renderer) => this.renderer = renderer;
        protected void Render(float radius) => renderer.RenderCircle(radius);

        public abstract void Draw();
        public abstract void Resize(float factor);
    }

    class Circle : Shape
    {
        private float radius;

        public Circle(IRenderer renderer, float radius) 
            : base(renderer)
        {
            this.radius = radius;
        }

        public override void Draw() => Render(radius);

        public override void Resize(float factor)
        {
            radius *= factor;
        }
    }
}
