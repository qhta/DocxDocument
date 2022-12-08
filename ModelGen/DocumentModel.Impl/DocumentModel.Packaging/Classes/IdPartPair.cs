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
    get;
    set;
  }
  
}
