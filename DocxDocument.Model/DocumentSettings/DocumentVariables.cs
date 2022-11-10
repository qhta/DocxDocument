namespace DocxDocument.Model;

public class DocumentVariables: IndexedCollection<string, object?>, IDocumentVariables
{
  public DocumentVariables() : base("Name")
  {
  }
}