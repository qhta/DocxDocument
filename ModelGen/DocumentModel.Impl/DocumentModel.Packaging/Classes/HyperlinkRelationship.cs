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
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.HyperlinkRelationship).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
