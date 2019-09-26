using System;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing;

namespace NotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********NOTA FISCAL*********");

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu endereço:");
            string endereco = Console.ReadLine();

            Console.WriteLine("Digite o valor da compra:");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data da compra:");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Document documento = new Document();
            Section notaFiscal = documento.AddSection();
            Paragraph tituloNotaFiscal = notaFiscal.AddParagraph();
            tituloNotaFiscal.AppendText("Nota Fiscal \n");
            Paragraph tituloNome = notaFiscal.AddParagraph();
            tituloNome.AppendText($"Nome: {nome} \n");
            Paragraph tituloEndereco = notaFiscal.AddParagraph();
            tituloEndereco.AppendText($"Endereço: {endereco}\n");
            Paragraph tituloValor = notaFiscal.AddParagraph();
            tituloValor.AppendText($"Valor da compra: {valor}");
            Paragraph tituloData = notaFiscal.AddParagraph();
            tituloData.AppendText($"Data: {data}");

            ParagraphStyle estiloTitulos = new ParagraphStyle(documento);
            estiloTitulos.Name = "Estilo dis Titulos";
            estiloTitulos.CharacterFormat.Bold = true;

            documento.Styles.Add(estiloTitulos);

            documento.SaveToFile(@"saida\notaFiscalWord.docx", FileFormat.Docx);

        }
    }
}
