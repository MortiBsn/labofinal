using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labofinal
{
    [Serializable]
    public class MyData : INotifyPropertyChanged
    {
        private ObservableCollection<Anime> _ListeAnime = null;
        private Anime anime;

        public ObservableCollection<Anime> ListAnime
        {
            get { return _ListeAnime; }
            set
            {
                if (_ListeAnime == value) return;
                _ListeAnime = value;
                OnPropertyChanged();
            }
        }

        private Anime _currentAnime;

        public Anime CurrentAnime
        {
            get { return _currentAnime; }
            set
            {
                if (_currentAnime == value) return;
                _currentAnime = value;
                OnPropertyChanged();
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public MyData() 
        {
            ListAnime = new ObservableCollection<Anime>();
            anime = new Anime();
            ListAnime.Add(new Anime("Death Note", DateTime.Now, "file:///C:/Users/clicb/Desktop/2eme/Partie%202/C%23/Labo/1200px-Death_Note,_Book.svg.png", 10, false, new Ecrivain("Tsugumi", "Ōba",0), new Genre("Mystère")));
        }
        public MyData(string name) { }
        public string Name { get; set; }
        public string Description { get; set; }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
