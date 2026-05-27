using MauiAppServicodeViagens.Models;

namespace MauiAppServicodeViagens
    {
        public partial class App : Application
        {
            public static List<Pacotes> Lista_pacotes = new()
        {
            new Pacotes()
            {
                Descricao = "Viagem Grandes Sonhos",
                ValorDiariaAdulto = 100.0,
                ValorDiariaCrianca = 50.0
            },
            new Pacotes()
            {
                Descricao = "Viagem Doces Sonhos",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },
            new Pacotes()
            {
                Descricao = "Viagem Sonhos de Conforto",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 25
            },
            new Pacotes()
            {
                Descricao = "Viagem Pequenos Sonhos",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca = 12.5
            }
        };
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var w = new Window(new AppShell());

            w.Height = 700;
            w.Width = 350;

            return w;
        }
    }
}