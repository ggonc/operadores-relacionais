int nota = 0;

Console.WriteLine("Informe a nota do aluno: ");
nota = int.Parse(Console.ReadLine());

if (nota >= 0 && nota < 5)
    Console.WriteLine("Reprovado");
else if (nota >= 5 && nota < 7)
    Console.WriteLine("Recuperação");
else if (nota >= 7 && nota <= 10)
    Console.WriteLine("Aprovado");
else
    Console.WriteLine("Nota inválida");

var aprovado = (nota >= 7) ? "Aprovado" : "Recuperação";
var situacao = nota >= 5 ? aprovado : "Reprovado";
Console.WriteLine(situacao);
