using s5fchamorro.Models;

namespace s5fchamorro.Views;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void btnInsertar_Clicked(object sender, EventArgs e)
    {
        status.Text = "";
        App.personRepo.AddNewPerson(txtNombre.Text);
        status.Text = App.personRepo.StatusMessage;

        actualizarListado();

    }

    private void btnListar_Clicked(object sender, EventArgs e)
    {
        status.Text = "";
        List<Persona> people = App.personRepo.GetAllPeople();
        ListarPersonas.ItemsSource = people;

    }

    Persona personaAux= new Persona();
    private void ListarPersonas_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var currentSelection = e.CurrentSelection.FirstOrDefault() as Persona;
        personaAux= currentSelection;
        if (currentSelection != null)
        {
            // Realiza acciones con el elemento seleccionado, por ejemplo:
            DisplayAlert("Seleccionado", $"Has seleccionado: {currentSelection.Nombre}", "OK");
         
        }

    }

    

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {

        var button = sender as Button;
        var personaAux = button?.BindingContext as Persona;
        if (personaAux != null)
        {
            App.personRepo.DeletePerson(personaAux);
            DisplayAlert("Eliminando", $"Has eliminado: {personaAux.Nombre}", "OK");
        }

        actualizarListado();
    }

    private void actualizarListado()
    {
        status.Text = "";
        List<Persona> people = App.personRepo.GetAllPeople();
        ListarPersonas.ItemsSource = people;
    }

    private void btnactualizar_Clicked(object sender, EventArgs e)
    {

        var button = sender as Button;
        var personaAux = button?.BindingContext as Persona;
        if (personaAux != null)
        {
            App.personRepo.updatePerson(personaAux);
            DisplayAlert("Actualizando", $"Has actualizado: {personaAux.Nombre}", "OK");
        }

    }
}