using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class CadastroEvento : ContentPage
{
    private Evento evento;

    public CadastroEvento()
    {
        InitializeComponent();

        evento = new Evento
        {
            DataInicio = DateTime.Now,
            DataFim = DateTime.Now.AddDays(1),
            NumeroParticipantes = 1,
            CustoPorParticipante = 0
        };

        BindingContext = evento;
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        // Validações básicas
        if (string.IsNullOrWhiteSpace(evento.Nome))
        {
            await DisplayAlert("Erro", "Informe o nome do evento", "OK");
            return;
        }

        if (evento.DataFim < evento.DataInicio)
        {
            await DisplayAlert("Erro", "A data de término deve ser maior ou igual à data de início", "OK");
            return;
        }

        if (evento.NumeroParticipantes <= 0)
        {
            await DisplayAlert("Erro", "Informe um número válido de participantes", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(evento.Local))
        {
            await DisplayAlert("Erro", "Informe o local do evento", "OK");
            return;
        }

        if (evento.CustoPorParticipante <= 0)
        {
            await DisplayAlert("Erro", "Informe um custo válido por participante", "OK");
            return;
        }

        // Navega para página de resumo e passa o evento
        await Navigation.PushAsync(new ResumoEvento(evento));
    }
}
