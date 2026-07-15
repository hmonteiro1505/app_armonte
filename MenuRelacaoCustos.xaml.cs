using System.Windows.Controls;
using armonte_aplicacao.ViewModels;

namespace armonte_aplicacao
{
    public partial class MenuRelacaoCustos : UserControl
    {
        public MenuRelacaoCustos(int projetoId)
        {
            InitializeComponent();
            ObrasViewControl.DataContext = new ObrasViewModel(projetoId);
            FornecedoresViewControl.DataContext = new FornecedorViewModel(projetoId);
        }
    }
}