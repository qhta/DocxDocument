using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticCutout Class.
/// </summary>
public static class ArtisticCutoutConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticCutout? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticCutout? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   numberOfShades, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetNumberOfShades(ArtisticCutout? openXmlElement)
  {
    return openXmlElement?.NumberOfShades?.Value;
  }

  public static void SetNumberOfShades(ArtisticCutout? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.NumberOfShades = value;
  }

  public static DocumentModel.Drawings.ArtisticCutout? CreateModelElement(ArtisticCutout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticCutout();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.NumberOfShades = GetNumberOfShades(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticCutout? value)
    where OpenXmlElementType : ArtisticCutout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetNumberOfShades(openXmlElement, value?.NumberOfShades);
      return openXmlElement;
    }
    return default;
  }
}