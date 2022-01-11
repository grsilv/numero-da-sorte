// Número da sorte, um jogo onde o usuário escolhe um número de 1 a 10 e uma mensagem especial aparece. 

{
    Console.Write("Escolha um número de 1 a 10: ");
    int x = int.Parse(Console.ReadLine());

    switch (x)
    {
        case 1:
            Console.WriteLine("Procure sempre os caminhos mais distantes.");
            break;

        case 2:
            Console.WriteLine("Evite se estressar com problemas.");
            break;

        case 3:
            Console.WriteLine("Mantenha a esperança naquilo que procura.");
            break;

        case 4:
            Console.WriteLine("Siga os sonhos de hoje");
            break;

        case 5:
            Console.WriteLine("Paciência, você ainda é jovem.");
            break;

        case 6:
            Console.WriteLine("Aprenda a se amar antes de tentar amar alguém.");
            break;

        case 7:
            Console.WriteLine("Autoestima é tudo.");
            break;

        case 8:
            Console.WriteLine("Seus talentos não te definem, mas te fortalecem.");
            break;

        case 9:
            Console.WriteLine("Você é mais que um título.");
            break;

        case 10:
            Console.WriteLine("Pare de lutar por quem já desistiu.");
            break;

        default:
            Console.WriteLine("Número inválido. Tente outro.");
            break;

    }
}