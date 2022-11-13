using System.Linq;

namespace DocxDocument.Model;

public interface IDocumentVariable
{
  public string Name { get; set; }

  public object? Value { get; set; }
}