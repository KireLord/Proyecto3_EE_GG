using Proyecto2_EE_GG.Models;
using Proyecto2_EE_GG.Services;
using System.Collections.ObjectModel;

namespace Proyecto2_EE_GG.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        ObservableCollection<AnimalesLogo> _users;
        ObservableCollection<Animales> _posts;

        public HomeViewModel()
        {
            LoadData();
        }

        public ObservableCollection<AnimalesLogo> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Animales> Posts
        {
            get { return _posts; }
            set
            {
                _posts = value;
                OnPropertyChanged();
            }
        }

        void LoadData()
        {
            Users = new ObservableCollection<AnimalesLogo>(AnimalesLogoService.Instance.GetUsers());
            Posts = new ObservableCollection<Animales>(AnimalesService.Instance.GetPosts());
        }
    }
}