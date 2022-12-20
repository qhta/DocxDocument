namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontRelationshipType Class.
/// </summary>
public partial class FontRelationshipTypeImpl: ModelElementImpl, FontRelationshipType
{
  public DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FontRelationshipTypeImpl(): base() {}
  
  public FontRelationshipTypeImpl(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// fontKey
  /// </summary>
  public String? FontKey
  {
    get => (System.String?)OpenXmlElement?.FontKey?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Subsetted?.Value;
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
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
