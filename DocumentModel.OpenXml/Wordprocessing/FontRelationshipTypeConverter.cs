namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FontRelationshipType Class.
/// </summary>
public static class FontRelationshipTypeConverter
{
  /// <summary>
  /// fontKey
  /// </summary>
  public static String? GetFontKey(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType? openXmlElement)
  {
    return openXmlElement?.FontKey?.Value;
  }
  
  public static void SetFontKey(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FontKey = new StringValue { Value = value };
      else
        openXmlElement.FontKey = null;
  }
  
  /// <summary>
  /// subsetted
  /// </summary>
  public static Boolean? GetSubsetted(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType? openXmlElement)
  {
    return openXmlElement?.Subsetted?.Value;
  }
  
  public static void SetSubsetted(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Subsetted = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Subsetted = null;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.FontRelationshipType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FontRelationshipType();
      value.FontKey = GetFontKey(openXmlElement);
      value.Subsetted = GetSubsetted(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FontRelationshipType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
