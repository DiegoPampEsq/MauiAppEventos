using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class ResumoEvento : ContentPage
{
    public Evento Evento { get; private set; }

    public ResumoEvento(Evento evento)
    {
        InitializeComponent();

        Evento = evento;

        Evento.DuracaoDias = (evento.DataFim - evento.DataInicio).Days + 1;
        Evento.CustoTotal = Evento.DuracaoDias * Evento.NumeroParticipantes * Evento.CustoPorParticipante;

        BindingContext = Evento;
    }
}
