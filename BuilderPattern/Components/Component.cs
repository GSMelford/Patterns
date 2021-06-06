namespace BuilderPattern.Components
{
    public abstract class Component
    {
        public string Name { get; set; }

        public Component(string name)
        {
            Name = name;
        }
    }
}