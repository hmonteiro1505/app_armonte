using armonte_aplicacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace armonte_aplicacao.Data
{
    public class Bootstrap
    {
        public Bootstrap()
        {
            using var db = new AppDbContext();

            // Evita duplicar dados se já correu antes
            if (db.ProjetoObraRelacaoCustos.Any())
                return;

            // ---- Projeto ----
            ProjetoObraRelacaoCustos projeto1 = new ProjetoObraRelacaoCustos
            {
                Designacao = "OBRA ADÃO FERNANDO SANTANA DA SILVA - TUIAS",
                AnoRegularizacao = "2026",
                InicioObra = DateTime.Parse("2025-06-03")
            };

            // ---- Cliente ----
            Cliente cliente1 = new Cliente
            {
                Nome = "ADÃO FERNANDO SANTANA DA SILVA",
                FaturasAutos = new List<FaturaCliente>()
            };
            projeto1.Clientes.Add(cliente1);

            // ---- Obra ----
            Obras obra1 = new Obras
            {
                Projeto = projeto1,
                Nome = projeto1.Designacao,
                Tipo = ObrasTipo.UM,
                Morada = "TRAVESSA DO POMAR - 4630-271 - MARCO DE CANAVESESES",
                MoradaContabilistica = "RUA AGOSTINHO ARMANDO LOUREIRO 360 - 4630-216 - MARCO DE CANAVESES"
            };
            projeto1.Obras.Add(obra1);

            // ---- Fornecedores ----
            List<Fornecedor> fornecedores = new List<Fornecedor>
            {
                CriarFornecedor("ACAIL - ARAME",
                    new[] { "01/2025" }, 27.09m, 6.23m, 33.32m, null, 33.32m),

                CriarFornecedor("ACTION",
                    new[] { "10/2025" }, 2.12m, 0.49m, 2.61m, null, 2.61m),

                CriarFornecedor("ADRIANO FERRAZ, LDA",
                    new[] { "05/2026" }, 1398.41m, 321.63m, 1720.04m, null, 1720.04m),

                CriarFornecedor("ALBERTO QUEIRÓS & FILHO, LDA",
                    new[] { "05/2026" }, 2576.59m, 592.61m, 3169.20m, null, 3169.20m),

                CriarFornecedor("ANTÓNIO TEIXEIRA PINTO DA SILVA",
                    new[] { "02/2026" }, 585.37m, 134.63m, 720.00m, null, 720.00m),

                CriarFornecedor("COUTOSCLIMA, LDA",
                    new[] { "05/2026" }, 0m, 0m, 0m, 1150.00m, 1150.00m),

                CriarFornecedor("DECAPPA",
                    new[] { "09/2025" }, 65.00m, 14.95m, 79.95m, null, 79.95m),

                CriarFornecedor("IRMÃOS LOURENÇO",
                    new[] { "10/2025", "01/2026", "04/2026", "05/2026", "06/2026" },
                    2745.80m, 631.53m, 3377.33m, null, 3377.33m),

                CriarFornecedor("LUIS BELCHIOR TEIXEIRA",
                    new[] { "09/2025" }, 350.00m, 80.50m, 430.50m, null, 430.50m),

                CriarFornecedor("MAQUIVESSADAS",
                    new[] { "10/2025" }, 110.80m, 25.48m, 136.28m, null, 136.28m),

                CriarFornecedor("MAQUIVESSADAS",
                    new[] { "05/2026" }, 2.12m, 0.49m, 2.61m, null, 2.61m),

                CriarFornecedor("MAQUIVESSADAS - 3 TUBOS MASSA CONSISTENTE",
                    new[] { "09/2025" }, 13.14m, 3.02m, 16.16m, null, 16.16m),

                CriarFornecedor("MATERIAL DA OBRA PARA O ARMAZEM - 2026",
                    new[] { "03/2026" }, -266.96m, -61.40m, -328.36m, null, -328.36m),

                CriarFornecedor("MATERIAL - ARMAZEM PARA A OBRA - 2026",
                    new[] { "02/2026", "03/2026", "04/2026", "05/2026" },
                    432.26m, 99.42m, 531.68m, null, 531.68m),

                CriarFornecedor("NOGUEIRA E RIBEIRO - PREGOS",
                    new[] { "12/2024", "09/2025" }, 4494.30m, 1033.69m, 5527.99m, null, 5527.99m),

                CriarFornecedor("SECIL BETÃO",
                    new[] { "09/2025", "10/2025", "11/2025" },
                    7205.50m, 1657.27m, 8862.77m, null, 8862.77m),

                CriarFornecedor("TEB, LDA",
                    new[] { "03/2026" }, 1532.44m, 352.46m, 1884.90m, null, 1884.90m),

                CriarFornecedor("TRANSPORTES BARÃO",
                    new[] { "09/2025" }, 195.00m, 44.85m, 239.85m, null, 239.85m),

                CriarFornecedor("VILABONENSE",
                    new[] { "09/2025", "10/2025", "11/2025", "12/2025" },
                    4385.50m, 1008.66m, 5394.16m, null, 5394.16m),

                CriarFornecedor("VILABONENSE",
                    new[] { "02/2026", "03/2026", "04/2026", "05/2026", "06/2026" },
                    6366.89m, 1464.39m, 7831.28m, null, 7831.28m),
            };

            foreach (var f in fornecedores)
                projeto1.Fornecedores.Add(f);

            // ---- Gravar tudo ----
            db.ProjetoObraRelacaoCustos.Add(projeto1);
            db.SaveChanges();
        }

        private static Fornecedor CriarFornecedor(
            string nome,
            string[] mesesAno,
            decimal valorSemIva,
            decimal iva,
            decimal valorComIva,
            decimal? faturaAutoLiquidacao,
            decimal valorTotal)
        {
            var fornecedor = new Fornecedor { Nome = nome };

            for (int i = 0; i < mesesAno.Length; i++)
            {
                var partes = mesesAno[i].Split('/');
                int mes = int.Parse(partes[0]);
                int ano = int.Parse(partes[1]);

                bool primeira = i == 0;

                fornecedor.FaturasAssociadas.Add(new FaturaFornecedor
                {
                    Data = new DateTime(ano, mes, 1),
                    ValorSemIva = primeira ? valorSemIva : 0m,
                    Iva = primeira ? iva : 0m,
                    ValorComIva = primeira ? valorComIva : 0m,
                    FaturaAutoLiquidacao = primeira ? faturaAutoLiquidacao : null,
                    ValorTotal = primeira ? valorTotal : 0m
                });
            }

            return fornecedor;
        }
    }
}