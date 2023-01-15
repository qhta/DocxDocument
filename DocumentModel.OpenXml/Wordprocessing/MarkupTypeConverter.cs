using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the MarkupType Class.
/// </summary>
public static class MarkupTypeConverter
{
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(MarkupType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(MarkupType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static DocumentModel.Wordprocessing.MarkupType? CreateModelElement(MarkupType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MarkupType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.MarkupType? value)
    where OpenXmlElementType : MarkupType, new()
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