using Proyecto2_EE_GG.Models;

namespace Proyecto2_EE_GG.Services
{
    public class AnimalesService
    {
        static AnimalesService _instance;

        public static AnimalesService Instance
        {
            get
            {
                _instance ??= new AnimalesService();

                return _instance;
            }
        }

        public List<Animales> GetPosts()
        {
            return new List<Animales>
            {
                new Animales { Title = "Leon", Image = "leon.jpg", User = AnimalesLogoService.Instance.User1 },
                new Animales { Title = "Oso", Image = "oso.jpg", User = AnimalesLogoService.Instance.User2 },
                new Animales { Title = "Zebra", Image = "zebra.jpg", User = AnimalesLogoService.Instance.User3 },
                new Animales { Title = "Cocodrilo", Image = "coco.jpg", User = AnimalesLogoService.Instance.User4 },
                new Animales { Title = "Mono", Image = "mono.jpg", User = AnimalesLogoService.Instance.User5 },
                new Animales { Title = "Tigre", Image = "tigre.jpg", User = AnimalesLogoService.Instance.User6 },
                new Animales { Title = "Hipopotamo", Image = "hipopotamo.jpg", User = AnimalesLogoService.Instance.User7 },
                new Animales { Title = "Puma", Image = "puma.jpg", User = AnimalesLogoService.Instance.User8 }
            };
        }
    }
}