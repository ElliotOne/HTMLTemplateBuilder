# HTML Template Builder

HTML Template Builder is a C# console application that streamlines HTML template creation using a fluent interface.

## Usage

```csharp
using HTMLTemplateBuilder;

HtmlTemplateBuilder builder = new HtmlTemplateBuilder();

string htmlTemplate = builder
    .AddHeader("My HTML Template")
    .AddParagraph("This is a paragraph.")
    .AddList(new string[] { "Item 1", "Item 2", "Item 3" })
    .Build();
```

## Methods 

The `HtmlTemplateBuilder` class in this project provides the following methods for fluent HTML template construction:

- **`AddHeader(string title)`**
  - Adds an HTML header with the specified title.

- **`AddParagraph(string text)`**
  - Appends an HTML paragraph with the given text.

- **`AddList(string[] items)`**
  - Inserts an unordered list (`<ul>`) containing the provided array of items.

- **`Build()`**
  - Finalizes the HTML template by closing the body and html tags and returns the constructed template as a string.

These methods enable users to seamlessly chain together calls for creating HTML documents with titles, paragraphs, and lists, providing a clean and expressive syntax for template building.

Feel free to customize and expand upon this template builder for your HTML construction needs.
