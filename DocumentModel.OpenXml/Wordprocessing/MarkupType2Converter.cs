using DocumentModel.Wordprocessing;
using MarkupType = DocumentFormat.OpenXml.Office2010.Word.MarkupType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the MarkupType Class.
/// </summary>
public static class MarkupType2Converter
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

  public static MarkupType2? CreateModelElement(MarkupType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new MarkupType2();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(MarkupType2? value)
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