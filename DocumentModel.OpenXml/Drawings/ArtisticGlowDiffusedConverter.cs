namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticGlowDiffused Class.
/// </summary>
public static class ArtisticGlowDiffusedConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticGlowDiffused openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticGlowDiffused openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetIntensity(DXO2010Draw.ArtisticGlowDiffused openXmlElement)
  {
    return openXmlElement.Intensity?.Value;
  }
  
  private static void SetIntensity(DXO2010Draw.ArtisticGlowDiffused openXmlElement, Int32? value)
  {
    openXmlElement.Intensity = value;
  }
  
  public static DMDraws.ArtisticGlowDiffused? CreateModelElement(DXO2010Draw.ArtisticGlowDiffused? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticGlowDiffused();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Intensity = GetIntensity(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticGlowDiffused? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticGlowDiffused, new()
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
