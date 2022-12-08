namespace DocumentModel.Packaging;

/// <summary>
/// Represents a hyperlink relationship.
/// </summary>
public class HyperlinkRelationshipImpl: DocumentModel.Packaging.ReferenceRelationshipImpl, HyperlinkRelationship
{
  public new DocumentFormat.OpenXml.Packaging.HyperlinkRelationship? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.HyperlinkRelationship?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets the relationship type.
  /// </summary>
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
