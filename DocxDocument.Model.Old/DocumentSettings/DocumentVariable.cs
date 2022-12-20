namespace DocxDocument.Model;

public class DocumentVariable : DocxBasedElement<WD.DocumentVariable>, IDocumentVariable
{
  public DocumentVariable(WD.DocumentVariable docxElement) : base(docxElement)
  {
  }
  public DocumentVariable() : base(new WD.DocumentVariable())
  {
  }

  public string Name
  {
    get => DocxElement.Name?.Value ?? "";
    set => DocxElement.Name = value;
  }

  public object? Value
  {
    get => DocxElement.Val?.Value ?? "";
    set => DocxElement.Val = value?.ToString();
  }
}
