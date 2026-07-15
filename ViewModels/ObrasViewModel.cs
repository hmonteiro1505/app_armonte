using System;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using armonte_aplicacao.Data;
using armonte_aplicacao.Models;

namespace armonte_aplicacao.ViewModels
{
    public partial class ObrasViewModel : ObservableObject
    {
        private readonly int _projetoId;

        public ObservableCollection<Obras> ListaObras { get; set; } = new();
        public Array TiposDisponiveis => Enum.GetValues(typeof(ObrasTipo));

        [ObservableProperty]
        private string textoPesquisa = string.Empty;

        public ObrasViewModel(int projetoId)
        {
            _projetoId = projetoId;
            CarregarObras();
        }

        public ObrasViewModel() { }

        private void CarregarObras()
        {
            using var db = new AppDbContext();
            ListaObras.Clear();
            var obrasDoProjeto = db.Obras
                .Where(o => o.ProjetoId == _projetoId)
                .ToList();
            foreach (var obra in obrasDoProjeto)
                ListaObras.Add(obra);
        }

        [RelayCommand]
        private void Pesquisar()
        {
            using var db = new AppDbContext();
            ListaObras.Clear();

            var query = db.Obras.Where(o => o.ProjetoId == _projetoId);

            if (!string.IsNullOrWhiteSpace(TextoPesquisa))
            {
                query = query.Where(o =>
                    o.Nome.Contains(TextoPesquisa) ||
                    o.Morada.Contains(TextoPesquisa) ||
                    o.MoradaContabilistica.Contains(TextoPesquisa));
            }

            foreach (var obra in query.ToList())
                ListaObras.Add(obra);
        }

        [RelayCommand]
        private void AbrirFormularioAdicionar()
        {
          
        }

        [RelayCommand]
        private void RemoverObra(Obras? obra)
        {

            if (obra is null) return;

            using var db = new AppDbContext();
            db.Obras.Remove(obra);
            db.SaveChanges();

            ListaObras.Remove(obra);
        }
    }
}