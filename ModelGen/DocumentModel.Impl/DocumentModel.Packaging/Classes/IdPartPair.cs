namespace DocumentModel.Packaging;

/// <summary>
/// Represents a (RelationshipId, OpenXmlPart) pair.
/// </summary>
public partial class IdPartPairImpl: ModelObjectImpl, IdPartPair
{
  public DocumentFormat.OpenXml.Packaging.IdPartPair? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.IdPartPair?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public IdPartPairImpl(): base() {}
  
  public IdPartPairImpl(DocumentFormat.OpenXml.Packaging.IdPartPair openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the relationship ID in the pair.
  /// </summary>
  public String? RelationshipId
  {
    get => (System.String?)OpenXmlElement?.RelationshipId;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.IdPartPair).GetProperty("RelationshipId")?.SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the OpenXmlPart in the pair.
  /// </summary>
  public DocumentModel.Packaging.OpenXmlPart? OpenXmlPart
  {
    get
    {
      if (OpenXmlElement?.OpenXmlPart != null)
        return new DocumentModel.Packaging.OpenXmlPartImpl(OpenXmlElement.OpenXmlPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.OpenXmlPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.OpenXmlPart = valueImpl.OpenXmlElement;
    }
  }
  
}
