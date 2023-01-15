using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Miter Line Join.
/// </summary>
public static class MiterConverter
{
  /// <summary>
  ///   Miter Join Limit
  /// </summary>
  public static Int32? GetLimit(Miter? openXmlElement)
  {
    return openXmlElement?.Limit?.Value;
  }

  public static void SetLimit(Miter? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Limit = value;
  }

  public static DocumentModel.Drawings.Miter? CreateModelElement(Miter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Miter();
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Miter? value)
    where OpenXmlElementType : Miter, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLimit(openXmlElement, value?.Limit);
      return openXmlElement;
    }
    return default;
  }
}