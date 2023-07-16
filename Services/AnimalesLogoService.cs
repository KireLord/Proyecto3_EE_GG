using Proyecto2_EE_GG.Models;

namespace Proyecto2_EE_GG.Services
{
    public class AnimalesLogoService
    {
        static AnimalesLogoService _instance;

        public static AnimalesLogoService Instance
        {
            get
            {
                _instance ??= new AnimalesLogoService();

                return _instance;
            }
        }

        public readonly AnimalesLogo User1 = new AnimalesLogo
        {
            Name = "",
            Image = "leon.jpg",
            Color = Color.FromArgb("#62D7FB"),
            From = "Africa"
        };

        public readonly AnimalesLogo User2 = new AnimalesLogo
        {
            Name = "",
            Image = "oso.jpg",
            Color = Color.FromArgb("#9B4EC8"),
            From = "América del Norte"
        };

        public readonly AnimalesLogo User3 = new AnimalesLogo
        {
            Name = "",
            Image = "zebra.jpg",
            Color = Color.FromArgb("#CE4E8C"),
            From = "Africa"
        };

        public readonly AnimalesLogo User4 = new AnimalesLogo
        {
            Name = "",
            Image = "coco.jpg",
            Color = Color.FromArgb("#4660C7"),
            From = "Australia"
        };

        public readonly AnimalesLogo User5 = new AnimalesLogo
        {
            Name = "",
            Image = "mono.jpg",
            Color = Color.FromArgb("#AF75CD"),
            From = "Asia"
        };

        public readonly AnimalesLogo User6 = new AnimalesLogo
        {
            Name = "",
            Image = "tigre.png",
            Color = Color.FromArgb("#C9E6F8"),
            From = "Africa"
        };
        public readonly AnimalesLogo User7 = new AnimalesLogo
        {
            Name = "",
            Image = "hipopotamo.png",
            Color = Color.FromArgb("#C9E6F8"),
            From = "Africa"
        };

        public readonly AnimalesLogo User8 = new AnimalesLogo
        {
            Name = "",
            Image = "puma.png",
            Color = Color.FromArgb("#C9E6F8"),
            From = "Africa"
        };
        public List<AnimalesLogo> GetUsers()
        {
            return new List<AnimalesLogo>
            {
                User1, User2, User3, User4, User5, User6, User7, User8
            };
        }
    }
}