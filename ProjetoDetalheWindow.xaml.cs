using System.Windows;

namespace armonte_aplicacao
{
    public partial class ProjetoDetalheWindow : Window
    {
        public ProjetoDetalheWindow(int projetoId, string designacao)
        {
            InitializeComponent();
            Title = $"Projeto: {designacao}";
            ConteudoGrid.Children.Add(new MenuRelacaoCustos(projetoId));
        }
    }
}