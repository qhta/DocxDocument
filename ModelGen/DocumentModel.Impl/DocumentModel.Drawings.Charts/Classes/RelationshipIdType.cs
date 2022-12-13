namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the RelationshipIdType Class.
/// </summary>
public class RelationshipIdTypeImpl: ModelElementImpl, RelationshipIdType
{
  public DocumentFormat.OpenXml.Drawing.Charts.RelationshipIdType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RelationshipIdType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RelationshipIdTypeImpl(): base() {}
  
  public RelationshipIdTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.RelationshipIdType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Relationship Reference
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
