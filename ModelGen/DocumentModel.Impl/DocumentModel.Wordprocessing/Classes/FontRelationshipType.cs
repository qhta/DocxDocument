namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontRelationshipType Class.
/// </summary>
public class FontRelationshipTypeImpl: ModelElementImpl, FontRelationshipType
{
  public DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// fontKey
  /// </summary>
  public String? FontKey
  {
    get => (String?)OpenXmlElement?.FontKey?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FontKey = (System.String?)value;
    }
  }
  
  /// <summary>
  /// subsetted
  /// </summary>
  public Boolean? Subsetted
  {
    get => (Boolean?)OpenXmlElement?.Subsetted?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Subsetted = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Relationship to Part
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
