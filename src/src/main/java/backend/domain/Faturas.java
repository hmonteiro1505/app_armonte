package backend.domain;

import java.util.List;


public class Faturas {

    private String designacao;
    private String descricao;
    private List<FaturasConstituinte> constitunte;
    private long valorIva;
    private long valorSemIva;


    public Faturas() {
    }

    public Faturas(long valorSemIva, long valorIva, List<FaturasConstituinte> constitunte, String descricao, String designacao) {
        this.valorSemIva = valorSemIva;
        this.valorIva = valorIva;
        this.constitunte = constitunte;
        this.descricao = descricao;
        this.designacao = designacao;
    }

    public Faturas(String designacao, List<FaturasConstituinte> constitunte, long valorSemIva, long valorIva) {
        this.designacao = designacao;
        this.constitunte = constitunte;
        this.valorSemIva = valorSemIva;
        this.valorIva = valorIva;
    }

    public String getDesignacao() {
        return designacao;
    }



    public void setDesignacao(String designacao) {
        this.designacao = designacao;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public List<FaturasConstituinte> getConstitunte() {
        return constitunte;
    }

    public void setConstitunte(List<FaturasConstituinte> constitunte) {
        this.constitunte = constitunte;
    }


    public long getValorIva() {
        return valorIva;
    }

    public void setValorIva(long valorIva) {
        this.valorIva = valorIva;
    }

    public long getValorSemIva() {
        return valorSemIva;
    }

    public void setValorSemIva(long valorSemIva) {
        this.valorSemIva = valorSemIva;
    }

    @Override
    public String toString() {
        return "Faturas{" +
                "designacao='" + designacao + '\'' +
                ", descricao='" + descricao + '\'' +
                ", constitunte=" + constitunte +
                ", valorIva=" + valorIva +
                ", valorSemIva=" + valorSemIva +
                '}';
    }
}

enum FaturasTipo {
    UM,
    DOIS,
    TRES
}



