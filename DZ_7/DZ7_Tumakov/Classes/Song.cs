namespace DZ7_Tumakov.Classes
{
    public class Song
    {
        private string _name;
        private string _author;
        private Song _prev;   //связь с предыдущей песней в списке

        // Свойства

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public Song Prev
        {
            get { return _prev; }
            set { _prev = value; }
        }

        public Song()
        {
            Name = "Неизвестная песня";
            Author = "Неизвестный автор";
            Prev = null;
        }

        public Song(string name, string author, Song prev)
        {
            Name = name;
            Author = author;
            Prev = prev;
        }

        public string Title()
        {
            return $"Название: {Name}, исполнитель: {Author}";
        }

        public override bool Equals(object d)
        {
            if (d == null)
                return false;

            Song otherSong = d as Song;
            if (otherSong == null)
                return false;

            bool isSameName = string.Equals(this.Name, otherSong.Name, StringComparison.OrdinalIgnoreCase);
            bool isSameAuthor = string.Equals(this.Author, otherSong.Author, StringComparison.OrdinalIgnoreCase);

            return isSameName && isSameAuthor;
        }
    }
}
