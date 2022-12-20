namespace DocumentModel.Packaging;

/// <summary>
/// Represents a hyperlink relationship.
/// </summary>
public partial class HyperlinkRelationshipImpl: DocumentModel.Packaging.ReferenceRelationshipImpl, HyperlinkRelationship
{
  public new DocumentFormat.OpenXml.Packaging.HyperlinkRelationship? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.HyperlinkRelationship?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HyperlinkRelationshipImpl(): base() {}
  
  public HyperlinkRelationshipImpl(DocumentFormat.OpenXml.Packaging.HyperlinkRelationship openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the relationship type.
  /// </summary>
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
