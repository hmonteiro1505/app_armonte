using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using armonte_aplicacao.Data;
using armonte_aplicacao.Models;

namespace armonte_aplicacao.ViewModels
{
    public partial class FornecedorViewModel : ObservableObject
    {
        private readonly int _projetoId;

        public ObservableCollection<Fornecedor> ListaFornecedores { get; set; } = new();

        [ObservableProperty]
        private string textoPesquisa = string.Empty;

        public FornecedorViewModel(int projetoId)
        {
            _projetoId = projetoId;
            CarregarFornecedores();
        }

        public FornecedorViewModel() { }

        private void CarregarFornecedores()
        {
            using var db = new AppDbContext();
            ListaFornecedores.Clear();
            var fornecedoresDoProjeto = db.Fornecedores
                .Where(f => f.ProjetoId == _projetoId)
                .ToList();
            foreach (var fornecedor in fornecedoresDoProjeto)
                ListaFornecedores.Add(fornecedor);
        }

        [RelayCommand]
        private void Pesquisar()
        {
            using var db = new AppDbContext();
            ListaFornecedores.Clear();

            var query = db.Fornecedores.Where(f => f.ProjetoId == _projetoId);

            if (!string.IsNullOrWhiteSpace(TextoPesquisa))
            {
                query = query.Where(f => f.Nome.Contains(TextoPesquisa));
            }

            foreach (var fornecedor in query.ToList())
                ListaFornecedores.Add(fornecedor);
        }

        [RelayCommand]
        private void AbrirFormularioAdicionar()
        {
            // futuro: abrir janela de criação de Fornecedor
            // ex: var janela = new AdicionarFornecedorWindow(_projetoId);
            // if (janela.ShowDialog() == true) CarregarFornecedores();
        }

        [RelayCommand]
        private void RemoverFornecedor(Fornecedor? fornecedor)
        {
            if (fornecedor is null) return;

            using var db = new AppDbContext();
            db.Fornecedores.Remove(fornecedor);
            db.SaveChanges();

            ListaFornecedores.Remove(fornecedor);
        }
    }
}