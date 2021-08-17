// See https://aka.ms/new-console-template for more information

/* Herança múltipla não é permitida na maioria das linguagens.
 * A herança múltipla pode gerar o problema do diamante:
 * Uma ambiguidade causada pela existência do mesmo método em
 * mais de uma superclasse.*/

using ProblemaDoDiamante.Devices;

Printer printer = new Printer() { SerialNumber = 1548 };
printer.ProcessDoc("My letters");
printer.Print("My letters");

Scanner scanner = new Scanner() { SerialNumber = 5402 };
scanner.ProcessDoc("My dissertation");
Console.WriteLine(scanner.Scan());