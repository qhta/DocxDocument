namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FontRelationshipType Class.
/// </summary>
public static class FontRelationshipTypeConverter
{
  /// <summary>
  /// fontKey
  /// </summary>
  private static String? GetFontKey(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType openXmlElement)
  {
    return openXmlElement?.FontKey?.Value;
  }
  
  private static void SetFontKey(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FontKey = new StringValue { Value = value };
    else
      openXmlElement.FontKey = null;
  }
  
  /// <summary>
  /// subsetted
  /// </summary>
  private static Boolean? GetSubsetted(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType openXmlElement)
  {
    return openXmlElement?.Subsetted?.Value;
  }
  
  private static void SetSubsetted(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Subsetted = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Subsetted = null;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType openXmlElement, String? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFontKey(openXmlElement, value?.FontKey);
      SetSubsetted(openXmlElement, value?.Subsetted);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
