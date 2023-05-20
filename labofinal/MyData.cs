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
        private ObservableCollection<Ecrivain> _ListeEcrivain = null;
        private ObservableCollection<Genre> _ListeGenre=null;
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

        public ObservableCollection<Ecrivain> ListEcrivain
        {
            get { return _ListeEcrivain; }
            set {
                if (_ListeEcrivain == value) return;
                _ListeEcrivain = value;
                OnPropertyChanged();
            }

        }

        private Ecrivain _currentEcrivain;
        public Ecrivain CurrentEcrivain
        {
            get { return _currentEcrivain; }
            set
            {
                if (_currentEcrivain == value) return;
                _currentEcrivain = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Genre> ListGenre
        {
            get { return _ListeGenre; }
            set
            {
                if (_ListeGenre == value) return;
                _ListeGenre = value;
                OnPropertyChanged();
            }

        }

        private Genre _currentGenre;
        public Genre CurrentGenre
        {
            get { return _currentGenre; }
            set
            {
                if (_currentGenre == value) return;
                _currentGenre = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public MyData() 
        {
            ListEcrivain = new ObservableCollection<Ecrivain>();
            ListAnime = new ObservableCollection<Anime>();
            ListGenre = new ObservableCollection<Genre>();
            Genre g= new Genre("Mystère");
            Ecrivain e = new Ecrivain("Tsugumi", "Ōba", 0);
            ListAnime.Add(new Anime("Death Note", DateTime.Now, "file:///C:/Users/clicb/Desktop/2eme/Partie%202/C%23/Labo/1200px-Death_Note,_Book.svg.png", 10, false, e , new Genre("Mystère")));
            ListEcrivain.Add(e);
            ListGenre.Add(g);

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
