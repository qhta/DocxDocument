using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the PositiveSize2DType Class.
/// </summary>
public static class PositiveSize2DTypeConverter
{
  /// <summary>
  ///   Extent Length
  /// </summary>
  public static Int64? GetCx(PositiveSize2DType? openXmlElement)
  {
    return openXmlElement?.Cx?.Value;
  }

  public static void SetCx(PositiveSize2DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Cx = value;
  }

  /// <summary>
  ///   Extent Width
  /// </summary>
  public static Int64? GetCy(PositiveSize2DType? openXmlElement)
  {
    return openXmlElement?.Cy?.Value;
  }

  public static void SetCy(PositiveSize2DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Cy = value;
  }

  public static DocumentModel.Drawings.PositiveSize2DType? CreateModelElement(PositiveSize2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PositiveSize2DType();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PositiveSize2DType? value)
    where OpenXmlElementType : PositiveSize2DType, new()
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