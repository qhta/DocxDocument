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
    get;
    set;
  }
  
  /// <summary>
  /// subsetted
  /// </summary>
  public Boolean? Subsetted
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
}
