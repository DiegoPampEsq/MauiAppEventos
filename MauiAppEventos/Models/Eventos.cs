using System;
using System.ComponentModel;

namespace MauiAppEventos.Models
{
    public class Evento : INotifyPropertyChanged
    {
        private string nome = string.Empty;
        private DateTime dataInicio;
        private DateTime dataFim;
        private int numeroParticipantes;
        private string local = string.Empty;
        private double custoPorParticipante;

        private int duracaoDias;
        private double custoTotal;

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

        public int DuracaoDias
        {
            get => duracaoDias;
            private set
            {
                if (duracaoDias != value)
                {
                    duracaoDias = value;
                    OnPropertyChanged(nameof(DuracaoDias));
                }
            }
        }

        public double CustoTotal
        {
            get => custoTotal;
            private set
            {
                if (custoTotal != value)
                {
                    custoTotal = value;
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        // Método para calcular duração e custo total
        public void CalcularDuracaoECusto()
        {
            DuracaoDias = (DataFim - DataInicio).Days + 1;
            CustoTotal = DuracaoDias * NumeroParticipantes * CustoPorParticipante;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
