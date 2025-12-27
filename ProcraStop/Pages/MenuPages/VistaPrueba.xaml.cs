using ProcraStop.Models;

namespace ProcraStop.Pages.MenuPages;
public partial class VistaPrueba : ContentPage
{
	public VistaPrueba()
	{
		InitializeComponent();
        PostCollection.ItemsSource = ObtenerDatos();
    }

    private static List<Post> ObtenerDatos()
    {
        var listas = new List<Post>();
        for (int i = 0; i < 500; i++)
        {
            listas.Add(new Post
            {
                ProfileImage = "perfil.png",
                Title = "Cultura Informática",
                Time = "1h",
                Description = "Gracias por ser parte de nuestra comunidad... ¡Feliz Navidad a todos!",
                PostImage = "foto.jpg",
                Likes = 29,
                Comments = 8,
                Shares = 2
            });
        }
        return listas;
    }
}