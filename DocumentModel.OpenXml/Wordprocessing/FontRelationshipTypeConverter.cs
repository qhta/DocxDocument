namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FontRelationshipType Class.
/// </summary>
public static class FontRelationshipTypeConverter
{
  /// <summary>
  /// fontKey
  /// </summary>
  private static String? GetFontKey(DXW.FontRelationshipType openXmlElement)
  {
    return openXmlElement?.FontKey?.Value;
  }
  
  private static void SetFontKey(DXW.FontRelationshipType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FontKey = new StringValue { Value = value };
    else
      openXmlElement.FontKey = null;
  }
  
  /// <summary>
  /// subsetted
  /// </summary>
  private static Boolean? GetSubsetted(DXW.FontRelationshipType openXmlElement)
  {
    return openXmlElement?.Subsetted?.Value;
  }
  
  private static void SetSubsetted(DXW.FontRelationshipType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Subsetted = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Subsetted = null;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetId(DXW.FontRelationshipType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.FontRelationshipType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.FontRelationshipType? CreateModelElement(DXW.FontRelationshipType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FontRelationshipType();
      value.FontKey = GetFontKey(openXmlElement);
      value.Subsetted = GetSubsetted(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FontRelationshipType? value)
    where OpenXmlElementType: DXW.FontRelationshipType, new()
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
