using System.Linq;
using MahApps.Metro.Controls;
using MahApps.Metro.SampleData.MusicStore;
using ReactiveUI;
using Data = MahApps.Metro.SampleData.MusicStore.SampleData;

namespace TabControlSample
{
    public class ShellViewModel : ReactiveObject
    {
        public ReactiveList<Genre> Genres { get; set; }

        public ReactiveList<PanoramaGroup> Groups { get; set; }
        
        public string Title { get; set; }
        public int SelectedIndex { get; set; }
        public ReactiveList<Album> Albums { get; set; }
        public ReactiveList<Artist> Artists { get; set; }

        public ShellViewModel()
        {
            Genres = new ReactiveList<Genre>(Data.Genres);
            Albums = new ReactiveList<Album>(Data.Albums);
            Artists = new ReactiveList<Artist>(Data.Artists);
        }
    }
}
