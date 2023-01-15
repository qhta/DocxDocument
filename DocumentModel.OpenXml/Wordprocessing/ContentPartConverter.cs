using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the ContentPart Class.
/// </summary>
public static class ContentPartConverter
{
  /// <summary>
  ///   id
  /// </summary>
  public static String? GetId(ContentPart? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(ContentPart? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static DocumentModel.Wordprocessing.ContentPart? CreateModelElement(ContentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ContentPart();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ContentPart? value)
    where OpenXmlElementType : ContentPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}