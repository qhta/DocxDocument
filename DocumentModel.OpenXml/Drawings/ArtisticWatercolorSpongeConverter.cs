using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticWatercolorSponge Class.
/// </summary>
public static class ArtisticWatercolorSpongeConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticWatercolorSponge? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticWatercolorSponge? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetBrushSize(ArtisticWatercolorSponge? openXmlElement)
  {
    return openXmlElement?.BrushSize?.Value;
  }

  public static void SetBrushSize(ArtisticWatercolorSponge? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.BrushSize = value;
  }

  public static DocumentModel.Drawings.ArtisticWatercolorSponge? CreateModelElement(ArtisticWatercolorSponge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticWatercolorSponge();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.BrushSize = GetBrushSize(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticWatercolorSponge? value)
    where OpenXmlElementType : ArtisticWatercolorSponge, new()
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