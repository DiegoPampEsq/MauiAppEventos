using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class ResumoEvento : ContentPage
{
    public Evento Evento { get; private set; }

    public ResumoEvento(Evento evento)
    {
        InitializeComponent();

        Evento = evento;
        Evento.CalcularDuracaoECusto();

        BindingContext = Evento;
    }
}
