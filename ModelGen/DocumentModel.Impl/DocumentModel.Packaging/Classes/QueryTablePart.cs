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
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
