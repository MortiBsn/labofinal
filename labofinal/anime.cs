using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace labofinal
{
    [Serializable]
    public class Anime : INotifyPropertyChanged
    {
        String _nomanime;
        DateTime  _dateAjout;
        String _image; // exemple d'imagefile:///C:/Users/clicb/Desktop/2eme/Partie%202/starzak/image/%C3%A7amarche.png
        int _cote;
        bool _enCours;
        Ecrivain _ecrivain;
        Genre _genre;

        public Ecrivain Ecrivain
        {
            get {return _ecrivain;} 
            set {_ecrivain= value;
                OnPropertyChanged();
            }
        }

        public Genre Genre
        {
            get { return _genre;}
            set { _genre= value;}
        }


        public DateTime DateAjout 
        { 
            get { return _dateAjout; } 
            set { _dateAjout = value; }
        }
        public String NomAnime
        {
            get { return _nomanime; }
            set { _nomanime = value; }
        }
        public String Image
        { 
            get { return _image; }
            set { _image = value; }
        }

        public int Cote
        { 
            get { return _cote; }
            set { _cote = value; }
        }

        public bool EnCours
        {
            get { return _enCours; }
            set { _enCours = value;}
        }

        public Anime() : this("NULL", DateTime.Now, "NULL", 0,false, new Ecrivain(), new Genre())
        { }

        public Anime(String NOMANIME, DateTime DATEAJOUT, String IMAGE, int COTE,bool ENCOURS, Ecrivain ECRIVAIN, Genre GENRE)
        {
            NomAnime = NOMANIME;
            DateAjout= DATEAJOUT;
            Image = IMAGE;
            Cote = COTE;
            EnCours = ENCOURS;
            Ecrivain = ECRIVAIN;
            Genre = GENRE;
        }
        public override string ToString()
        { 
            return "Date d'ajout  : " + DateAjout + "nomAnime : " + NomAnime + "Note/20 : " + Cote+ "Anime en cours : " + EnCours;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
    [Serializable]
    public class Genre : INotifyPropertyChanged
    {
        String _nomgenre;
        //int nbanimegenre;

        public String Nomgenre
        {
            get { return _nomgenre; }
            set { _nomgenre = value; }
        }

        /*public int NbAnimeGenre
        {
            get { return nbanimegenre; }
            set { nbanimegenre = value;}
        }*/
        public Genre() : this("null"/*,0*/)
        { }

        public Genre(string NOMGENRE/*, int NBANIMEGENRE*/)
        {
            Nomgenre= NOMGENRE;
            //NbAnimeGenre= NBANIMEGENRE;
        }

        /*public int NbGenre()
        {

            nbanimegenre++;
            return nbanimegenre;
        }*/

        public override string ToString()
        {
            return "Genre : " + Nomgenre/* + "Nombre d'animé (thèmes) : " + NbAnimeGenre*/;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

    [Serializable]
    public class Ecrivain : INotifyPropertyChanged
    {
        String _nomecrivain;
        string _prenomecrivain;
        int _age;
        

        public String NomEcrivain
        {
            get { return _nomecrivain; }
            set { _nomecrivain = value;}
        }
        public string PrenomEcrivain
        {
            get { return _prenomecrivain;}
            set { _prenomecrivain = value;}
        }
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
            }
        }
        public Ecrivain() : this ("Null","Null",0) { }
        public Ecrivain(string NOMECRIVAIN, string PRENOMECRIVAIN, int AGE)
        {
            NomEcrivain= NOMECRIVAIN;
            PrenomEcrivain = PRENOMECRIVAIN;
            Age= AGE;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
