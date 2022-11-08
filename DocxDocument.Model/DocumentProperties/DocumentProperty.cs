namespace DocxDocument.Model;

public class DocumentProperty: IDocumentProperty
{
  public string Name { get; set; } = null!;

  public PropertyType Type {get; set;}

  public object? Value { get; set; }
}