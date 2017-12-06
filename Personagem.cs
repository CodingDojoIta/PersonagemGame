namespace ConsoleApplication
{
    public class Personagem : PersonagemCaracteristicas
    {
        private int ouro { get; set; } = 5;

        public void CreatePersonagem(bool contaPremium, string nome, string roupaCor = "Blue", string cabeloCor = "Black")
        {
            if (contaPremium)
            {
                this.nome = nome;
                this.nivel = 50;
                this.poder = 8001;
                this.ouro = 5000;
                this.armaTipo = 3;
                this.roupaCor = roupaCor;
                this.cabeloCor = cabeloCor;
                
            }
            else // free
            {
                this.nome = nome;
                this.roupaCor = roupaCor;
                this.cabeloCor = cabeloCor;
            }
        }

        public string StatusPersonagem()
        {
            return $"Nome: {nome}\r\n" +
                   $"Nivel: {nivel}\r\n" +
                   $"Poder: {poder}\r\n" +
                   $"Ouro: {ouro}\r\n" +
                   $"Cor da Roupa: {roupaCor}\r\n" +
                   $"Cor do Cabelo: {cabeloCor}\r\n";
        }
    }
}
