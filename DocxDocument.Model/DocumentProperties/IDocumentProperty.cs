namespace DocxDocument.Model;

public interface IDocumentProperty
{
  public string Name { get; set; }

  public PropertyType Type {get; set;}

  public object? Value { get; set; }
}