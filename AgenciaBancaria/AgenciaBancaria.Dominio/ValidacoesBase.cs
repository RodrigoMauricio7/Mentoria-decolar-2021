namespace AgenciaBancaria.Dominio
{
    public static class ValidacoesBase
    {
        public string validaStringVazia(string texto)
        {
            return string.IsNullOrWhiteSpace(texto) ?
                throw new Exception("A propriedade deve está preenchida")
                : texto;
        }
    }
}