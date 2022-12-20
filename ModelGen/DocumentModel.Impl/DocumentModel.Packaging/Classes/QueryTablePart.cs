namespace DocumentModel.Packaging;

/// <summary>
/// Defines the QueryTablePart
/// </summary>
public partial class QueryTablePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, QueryTablePart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.QueryTablePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.QueryTablePart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public QueryTablePartImpl(): base() {}
  
  public QueryTablePartImpl(DocumentFormat.OpenXml.Packaging.QueryTablePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
