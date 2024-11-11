using Composite_pattern;
class Program
{
    static void Main(string[] args)
    {
        Document document = new Document();

        Section section = new Section("Введение");
        section.Add(new Paragraph("Текст введения"));

        Section section1 = new Section("Основная часть");
        section1.Add(new Paragraph("Текст основной части"));

        Section subsection = new Section("Подраздел 1.1");
        subsection.Add(new Paragraph("Текст подраздела 1.1."));

        Section subsection1 = new Section("Подраздел 1.2");
        subsection1.Add(new Paragraph("Текст подраздела 1.2"));

        section1.Add(subsection);
        section1.Add(subsection1);

        document.Add(section);
        document.Add(section1);

        document.Display();
    }
}