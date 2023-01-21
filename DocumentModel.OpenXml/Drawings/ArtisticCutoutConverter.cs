namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticCutout Class.
/// </summary>
public static class ArtisticCutoutConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticCutout openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticCutout openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// numberOfShades, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetNumberOfShades(DXO2010Draw.ArtisticCutout openXmlElement)
  {
    return openXmlElement.NumberOfShades?.Value;
  }
  
  private static void SetNumberOfShades(DXO2010Draw.ArtisticCutout openXmlElement, Int32? value)
  {
    openXmlElement.NumberOfShades = value;
  }
  
  public static DMDraws.ArtisticCutout? CreateModelElement(DXO2010Draw.ArtisticCutout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticCutout();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.NumberOfShades = GetNumberOfShades(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticCutout? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticCutout, new()
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
