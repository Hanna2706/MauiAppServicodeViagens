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

        public static List<Paises> Lista_paises = new()
        {
            new Paises()
            {
                Descricao = "Brasil"
            },
            new Paises()
            {
                Descricao = "França"
            },
            new Paises()
            {
                Descricao = "Portugal"
            },
            new Paises()
            {
                Descricao = "Canada"
            },
            new Paises()
            {
                Descricao = "Itália"
            },
            new Paises()
            {
                Descricao = "Espanha"
            },
            new Paises()
            {
                Descricao = "Estados Unidos"
            },
            new Paises()
            {
                Descricao = "México"
            },
            new Paises()
            {
                Descricao = "Japão"
            },
            new Paises()
            {
                Descricao = "China"
            },
            new Paises()
            {
                Descricao = "Coreia do Sul"
            },
            new Paises()
            {
                Descricao = "Rússia"
            },
            new Paises()
            {
                Descricao = "Alasca"
            },
            new Paises()
            {
                Descricao = "África do Sul"
            },
            new Paises()
            {
                Descricao = "Austrália"
            },
            new Paises()
            {
                Descricao = "Argentina"
            },
            new Paises()
            {
                Descricao = "Alemanha"
            },
            new Paises()
            {
                Descricao = "Costa Rica"
            },
            new Paises()
            {
                Descricao = "Dinamarca"
            },
            new Paises()
            {
                Descricao = "Egito"
            },
            new Paises()
            {
                Descricao = "Equador"
            },
            new Paises()
            {
                Descricao = "Filipinas"
            },
            new Paises()
            {
                Descricao = "Finlândia"
            },
            new Paises()
            {
                Descricao = "Fiji"
            },
            new Paises()
            {
                Descricao = "Grécia"
            },
            new Paises()
            {
                Descricao = "Holanda"
            },
            new Paises()
            {
                Descricao = "Irlanda"
            },
            new Paises()
            {
                Descricao = "Islândia"
            },
            new Paises()
            {
                Descricao = "Israel"
            },
            new Paises()
            {
                Descricao = "Inglaterra"
            },
            new Paises()
            {
            Descricao = "Índia"
            },
            new Paises()
            {
                Descricao = "Jamaica"
            },
            new Paises()
            {
                Descricao = "Luxemburgo"
            },
            new Paises()
            {
                Descricao = "Maldivas"
            },
            new Paises()
            {
                Descricao = "Marrocos"
            },
            new Paises()
            {
                Descricao = "Mônaco"
            },
            new Paises()
            {
                Descricao = "Noruega"
            },
            new Paises()
            {
                Descricao = "Nova Zelândia"
            },
            new Paises()
            {
                Descricao = "País de Gales"
            },
            new Paises()
            {
                Descricao = "Paraguai"
            },
            new Paises()
            {
                Descricao = "Peru"
            },
            new Paises()
            {
                Descricao ="Polônia"
            },
            new Paises()
            {
                Descricao = "Reino Unido"
            },
            new Paises()
            {
                Descricao = "Romênia"
            },
            new Paises()
            {
                Descricao = "Senegal"
            },
            new Paises()
            {
                Descricao = "Sévia"
            },
            new Paises()
            {
                Descricao = "Suécia"
            },
            new Paises()
            {
                Descricao = "Tailândia"
            },
            new Paises()
            {
                Descricao = "Turquia"
            },
            new Paises()
            {
                Descricao = "Uruguai"
            },
            new Paises()
            {
                Descricao = "Ucrânia"
            },
            new Paises()
            {
                Descricao = "Vaticano"
            },
            new Paises()
            {
                Descricao = "Venezuela"
            },
            new Paises()
            {
                Descricao = "Uganda"
            },
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