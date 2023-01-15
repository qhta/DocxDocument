using DocumentFormat.OpenXml.Vml.Office;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Ink.
/// </summary>
public static class InkConverter
{
  /// <summary>
  ///   Ink Data
  /// </summary>
  public static Byte[]? GetInkData(Ink? openXmlElement)
  {
    if (openXmlElement?.InkData?.Value != null)
      return Convert.FromBase64String(openXmlElement.InkData.Value);
    return null;
  }

  public static void SetInkData(Ink? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.InkData = Convert.ToBase64String(value);
      else
        openXmlElement.InkData = null;
    }
  }

  /// <summary>
  ///   Annotation Flag
  /// </summary>
  public static Boolean? GetAnnotationFlag(Ink? openXmlElement)
  {
    return openXmlElement?.AnnotationFlag?.Value;
  }

  public static void SetAnnotationFlag(Ink? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AnnotationFlag = value;
      else
        openXmlElement.AnnotationFlag = null;
  }

  public static DocumentModel.Vml.Ink? CreateModelElement(Ink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Ink();
      value.InkData = GetInkData(openXmlElement);
      value.AnnotationFlag = GetAnnotationFlag(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Ink? value)
    where OpenXmlElementType : Ink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetInkData(openXmlElement, value?.InkData);
      SetAnnotationFlag(openXmlElement, value?.AnnotationFlag);
      return openXmlElement;
    }
    return default;
  }
}