package backend.domain;

public class Fornecedores {


    private String nome;
    private String descricao;
    private String contacto;
    private String email;
    private String morada;

    public Fornecedores() {
    }

    public Fornecedores(String nome, String descricao, String contacto, String email, String morada) {
        this.nome = nome;
        this.descricao = descricao;
        this.contacto = contacto;
        this.email = email;
        this.morada = morada;
    }

    public Fornecedores(String nome, String contacto, String morada, String email) {
        this.nome = nome;
        this.contacto = contacto;
        this.morada = morada;
        this.email = email;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getDescrição() {
        return descricao;
    }

    public void setDescrição(String descrição) {
        this.descricao = descrição;
    }

    public String getContacto() {
        return contacto;
    }

    public void setContacto(String contacto) {
        this.contacto = contacto;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getMorada() {
        return morada;
    }

    public void setMorada(String morada) {
        this.morada = morada;
    }

    @Override
    public String toString() {
        return "Fornecedores{" +
                "nome='" + nome + '\'' +
                ", descrição='" + descricao + '\'' +
                ", contacto='" + contacto + '\'' +
                ", email='" + email + '\'' +
                ", morada='" + morada + '\'' +
                '}';
    }
}
