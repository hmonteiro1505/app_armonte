package backend.domain;

public class FaturasConstituinte {
    private String designacao;
    private String descricao;
    private ConstituinteTipo tipo;
    private long custo;

    public FaturasConstituinte(String designacao, String descricao, ConstituinteTipo tipo, long custo) {
        this.designacao = designacao;
        this.descricao = descricao;
        this.tipo = tipo;
        this.custo = custo;
    }

    /* sem descricao */
    public FaturasConstituinte(String designacao, ConstituinteTipo tipo, long custo) {
        this.designacao = designacao;
        this.tipo = tipo;
        this.custo = custo;
    }

    public FaturasConstituinte() {
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

    public ConstituinteTipo getTipo() {
        return tipo;
    }

    public void setTipo(ConstituinteTipo tipo) {
        this.tipo = tipo;
    }

    public long getCusto() {
        return custo;
    }

    public void setCusto(long custo) {
        this.custo = custo;
    }

    @Override
    public String toString() {
        return "FaturasConstituinte{" +
                "designacao='" + designacao + '\'' +
                ", descricao='" + descricao + '\'' +
                ", tipo=" + tipo +
                ", custo=" + custo +
                '}';
    }
}


enum ConstituinteTipo {

    Material,
    Serviço
}
