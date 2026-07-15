package backend.domain;

import java.util.List;

public class Obras {

    private String designacao;
    private String local;
    private List<Faturas> faturasAssociadas;
    private long saldo;

    public Obras() {
    }

    public Obras(String designacao, String local, List<Faturas> faturasAssociadas, long saldo) {
        this.designacao = designacao;
        this.local = local;
        this.faturasAssociadas = faturasAssociadas;
        this.saldo = saldo;
    }



    public String getDesignacao() {
        return designacao;
    }

    public void setDesignacao(String designacao) {
        this.designacao = designacao;
    }

    public String getLocal() {
        return local;
    }

    public void setLocal(String local) {
        this.local = local;
    }

    public List<Faturas> getFaturasAssociadas() {
        return faturasAssociadas;
    }

    public void setFaturasAssociadas(List<Faturas> faturasAssociadas) {
        this.faturasAssociadas = faturasAssociadas;
    }

    public long getSaldo() {
        return saldo;
    }

    public void setSaldo(long saldo) {
        this.saldo = saldo;
    }

    @Override
    public String toString() {
        return "Obras{" +
                "designacao='" + designacao + '\'' +
                ", local='" + local + '\'' +
                ", faturasAssociadas=" + faturasAssociadas +
                ", saldo=" + saldo +
                '}';
    }
}
