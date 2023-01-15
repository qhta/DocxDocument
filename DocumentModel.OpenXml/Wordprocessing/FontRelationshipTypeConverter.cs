using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the FontRelationshipType Class.
/// </summary>
public static class FontRelationshipTypeConverter
{
  /// <summary>
  ///   fontKey
  /// </summary>
  public static String? GetFontKey(FontRelationshipType? openXmlElement)
  {
    return openXmlElement?.FontKey?.Value;
  }

  public static void SetFontKey(FontRelationshipType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FontKey = new StringValue { Value = value };
      else
        openXmlElement.FontKey = null;
  }

  /// <summary>
  ///   subsetted
  /// </summary>
  public static Boolean? GetSubsetted(FontRelationshipType? openXmlElement)
  {
    return openXmlElement?.Subsetted?.Value;
  }

  public static void SetSubsetted(FontRelationshipType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Subsetted = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Subsetted = null;
  }

  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public static String? GetId(FontRelationshipType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(FontRelationshipType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static DocumentModel.Wordprocessing.FontRelationshipType? CreateModelElement(FontRelationshipType? openXmlElement)
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
    where OpenXmlElementType : FontRelationshipType, new()
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