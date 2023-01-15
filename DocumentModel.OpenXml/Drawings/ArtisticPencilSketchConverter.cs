using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticPencilSketch Class.
/// </summary>
public static class ArtisticPencilSketchConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticPencilSketch? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticPencilSketch? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetPressure(ArtisticPencilSketch? openXmlElement)
  {
    return openXmlElement?.Pressure?.Value;
  }

  public static void SetPressure(ArtisticPencilSketch? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pressure = value;
  }

  public static DocumentModel.Drawings.ArtisticPencilSketch? CreateModelElement(ArtisticPencilSketch? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPencilSketch();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Pressure = GetPressure(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticPencilSketch? value)
    where OpenXmlElementType : ArtisticPencilSketch, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetPressure(openXmlElement, value?.Pressure);
      return openXmlElement;
    }
    return default;
  }
}