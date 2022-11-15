namespace DocxDocument.Model;

public class CustomDocumentProperties: DocxBasedCollection<DM.CustomDocumentProperty, DM.ICustomDocumentProperty, CP.Properties, CP.CustomDocumentProperty>, ICustomDocumentProperties
{
  public CustomDocumentProperties() : base(new CP.Properties())
  {
  }

  public CustomDocumentProperties(CP.Properties element) : base(element)
  {
  }

}