namespace ModelsLibrary
{
    public class Animal : AbstractModel, IModel
    {
        private string _color;
        private string _habitat;
        private int _legCount;

        public string Color
        {
            get { return _color; }
            set { _color = value; OnPropertyChanged("Color");}
        }

        public string Habitat
        {
            get { return _habitat; }
            set { _habitat = value; OnPropertyChanged("Habitat"); }
        }

        public int LegCount
        {
            get { return _legCount; }
            set { _legCount = value; OnPropertyChanged("LegCount"); }
        }
    }
}
