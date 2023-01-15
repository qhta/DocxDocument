using DocumentFormat.OpenXml.Drawing.Wordprocessing;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Inline Drawing Object Extents.
/// </summary>
public static class ExtentConverter
{
  /// <summary>
  ///   Extent Length
  /// </summary>
  public static Int64? GetCx(Extent? openXmlElement)
  {
    return openXmlElement?.Cx?.Value;
  }

  public static void SetCx(Extent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Cx = value;
  }

  /// <summary>
  ///   Extent Width
  /// </summary>
  public static Int64? GetCy(Extent? openXmlElement)
  {
    return openXmlElement?.Cy?.Value;
  }

  public static void SetCy(Extent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Cy = value;
  }

  public static DocumentModel.Drawings.Wordprocessing.Extent? CreateModelElement(Extent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.Extent();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.Extent? value)
    where OpenXmlElementType : Extent, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCx(openXmlElement, value?.Cx);
      SetCy(openXmlElement, value?.Cy);
      return openXmlElement;
    }
    return default;
  }
}