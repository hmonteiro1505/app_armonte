using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using armonte_aplicacao.Data;
using armonte_aplicacao.Models;

namespace armonte_aplicacao.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<ProjetoObraRelacaoCustos> Projetos { get; set; } = new();

        public MainViewModel()
        {
            CarregarProjetos();
        }

        private void CarregarProjetos()
        {
            using var db = new AppDbContext();
            Projetos.Clear();
            foreach (var p in db.ProjetoObraRelacaoCustos.ToList())
                Projetos.Add(p);
        }

        [RelayCommand]
        private void AbrirProjeto(ProjetoObraRelacaoCustos? projeto)
        {
            if (projeto is null) return;

            var janela = new ProjetoDetalheWindow(projeto.Id, projeto.Designacao);
            janela.ShowDialog(); // abre como janela modal; usa .Show() se preferires não-modal
        }
    }
}