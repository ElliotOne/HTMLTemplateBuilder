using HTMLTemplateBuilder;

HtmlTemplateBuilder builder = new HtmlTemplateBuilder();

string htmlTemplate = builder
    .AddHeader("My HTML Template")
    .AddParagraph("This is a paragraph.")
    .AddList(new string[] { "Item 1", "Item 2", "Item 3" })
    .Build();

Console.WriteLine(htmlTemplate);

Console.ReadKey();
