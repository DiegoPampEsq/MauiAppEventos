using System;
using System.ComponentModel;

namespace MauiAppEventos.Models
{
    public class Evento : INotifyPropertyChanged
    {
        private string nome;
        private DateTime dataInicio;
        private DateTime dataFim;
        private int numeroParticipantes;
        private string local;
        private double custoPorParticipante;

        // Propriedades existentes
        public string Nome
        {
            get => nome;
            set
            {
                if (nome != value)
                {
                    nome = value;
                    OnPropertyChanged(nameof(Nome));
                }
            }
        }

        public DateTime DataInicio
        {
            get => dataInicio;
            set
            {
                if (dataInicio != value)
                {
                    dataInicio = value;
                    OnPropertyChanged(nameof(DataInicio));
                }
            }
        }

        public DateTime DataFim
        {
            get => dataFim;
            set
            {
                if (dataFim != value)
                {
                    dataFim = value;
                    OnPropertyChanged(nameof(DataFim));
                }
            }
        }

        public int NumeroParticipantes
        {
            get => numeroParticipantes;
            set
            {
                if (numeroParticipantes != value)
                {
                    numeroParticipantes = value;
                    OnPropertyChanged(nameof(NumeroParticipantes));
                }
            }
        }

        public string Local
        {
            get => local;
            set
            {
                if (local != value)
                {
                    local = value;
                    OnPropertyChanged(nameof(Local));
                }
            }
        }

        public double CustoPorParticipante
        {
            get => custoPorParticipante;
            set
            {
                if (custoPorParticipante != value)
                {
                    custoPorParticipante = value;
                    OnPropertyChanged(nameof(CustoPorParticipante));
                }
            }
        }

        // Novas propriedades calculadas (com backing fields e notificações)
        private int duracaoDias;
        public int DuracaoDias
        {
            get => duracaoDias;
            set
            {
                if (duracaoDias != value)
                {
                    duracaoDias = value;
                    OnPropertyChanged(nameof(DuracaoDias));
                }
            }
        }

        private double custoTotal;
        public double CustoTotal
        {
            get => custoTotal;
            set
            {
                if (custoTotal != value)
                {
                    custoTotal = value;
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        // Implementação do INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
