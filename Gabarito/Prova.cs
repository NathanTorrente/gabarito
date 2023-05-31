class Gabarito
{
    private List<char> respostas;

    public Gabarito(List<char> respostas)
    {
        this.respostas = respostas;
    }

    public char RespostaQuestao(int numQuestao)
    {
        return respostas[numQuestao - 1];
    }
}

