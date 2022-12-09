namespace DocumentModel.Packaging;

/// <summary>
/// Represents a (RelationshipId, OpenXmlPart) pair.
/// </summary>
public class IdPartPairImpl: ModelObjectImpl, IdPartPair
{
  public DocumentFormat.OpenXml.Packaging.IdPartPair? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.IdPartPair?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets or sets the relationship ID in the pair.
  /// </summary>
  public String? RelationshipId
  {
    get => (String?)OpenXmlElement?.RelationshipId;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.IdPartPair).GetProperty("RelationshipId").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
