using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticPencilGrayscale Class.
/// </summary>
public static class ArtisticPencilGrayscaleConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticPencilGrayscale? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticPencilGrayscale? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetBrushSize(ArtisticPencilGrayscale? openXmlElement)
  {
    return openXmlElement?.BrushSize?.Value;
  }

  public static void SetBrushSize(ArtisticPencilGrayscale? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.BrushSize = value;
  }

  public static DocumentModel.Drawings.ArtisticPencilGrayscale? CreateModelElement(ArtisticPencilGrayscale? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPencilGrayscale();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.BrushSize = GetBrushSize(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticPencilGrayscale? value)
    where OpenXmlElementType : ArtisticPencilGrayscale, new()
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