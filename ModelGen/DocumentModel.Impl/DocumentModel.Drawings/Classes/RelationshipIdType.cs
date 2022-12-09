namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// Relationship Reference
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
