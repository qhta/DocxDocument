using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticGlowDiffused Class.
/// </summary>
public static class ArtisticGlowDiffusedConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticGlowDiffused? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticGlowDiffused? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   intensity, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetIntensity(ArtisticGlowDiffused? openXmlElement)
  {
    return openXmlElement?.Intensity?.Value;
  }

  public static void SetIntensity(ArtisticGlowDiffused? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Intensity = value;
  }

  public static DocumentModel.Drawings.ArtisticGlowDiffused? CreateModelElement(ArtisticGlowDiffused? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticGlowDiffused();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Intensity = GetIntensity(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticGlowDiffused? value)
    where OpenXmlElementType : ArtisticGlowDiffused, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetIntensity(openXmlElement, value?.Intensity);
      return openXmlElement;
    }
    return default;
  }
}