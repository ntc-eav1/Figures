namespace ConsoleApp1.Model
{
    public abstract class FigureBase
    {
        protected static string _name;
        /*
        internal string Name
        {
            get { return _name; }
        }
        */
        public abstract double GetPerimeter();
        public abstract double GetSquare();
        public abstract string GetInfo();
    }
}
