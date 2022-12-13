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
  
  public QueryTablePartImpl(): base() {}
  
  public QueryTablePartImpl(DocumentFormat.OpenXml.Packaging.QueryTablePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.QueryTablePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.QueryTablePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
