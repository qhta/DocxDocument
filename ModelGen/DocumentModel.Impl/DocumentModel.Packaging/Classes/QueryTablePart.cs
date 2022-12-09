namespace DocumentModel.Packaging;

/// <summary>
/// Defines the QueryTablePart
/// </summary>
public class QueryTablePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, QueryTablePart
{
  public new DocumentFormat.OpenXml.Packaging.QueryTablePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.QueryTablePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.QueryTablePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.QueryTablePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
