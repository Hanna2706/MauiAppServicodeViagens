namespace MauiAppServicodeViagens.Models
{
    public class Viagem
    {
        public Pacotes PacoteSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }
        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * PacoteSelecionado.ValorDiariaAdulto;
                double valor_criancas = QntCriancas * PacoteSelecionado.ValorDiariaCrianca;

                double total = (valor_adultos + valor_criancas) * Estadia;

                return total;
            }
        }
    }
}
