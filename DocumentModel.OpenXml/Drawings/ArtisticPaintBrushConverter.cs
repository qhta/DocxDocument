using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticPaintBrush Class.
/// </summary>
public static class ArtisticPaintBrushConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticPaintBrush? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticPaintBrush? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetBrushSize(ArtisticPaintBrush? openXmlElement)
  {
    return openXmlElement?.BrushSize?.Value;
  }

  public static void SetBrushSize(ArtisticPaintBrush? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.BrushSize = value;
  }

  public static DocumentModel.Drawings.ArtisticPaintBrush? CreateModelElement(ArtisticPaintBrush? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPaintBrush();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.BrushSize = GetBrushSize(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticPaintBrush? value)
    where OpenXmlElementType : ArtisticPaintBrush, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetBrushSize(openXmlElement, value?.BrushSize);
      return openXmlElement;
    }
    return default;
  }
}