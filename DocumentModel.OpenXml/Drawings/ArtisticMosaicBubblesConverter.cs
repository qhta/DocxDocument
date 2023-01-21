namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticMosaicBubbles Class.
/// </summary>
public static class ArtisticMosaicBubblesConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticMosaicBubbles openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticMosaicBubbles openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetPressure(DXO2010Draw.ArtisticMosaicBubbles openXmlElement)
  {
    return openXmlElement.Pressure?.Value;
  }
  
  private static void SetPressure(DXO2010Draw.ArtisticMosaicBubbles openXmlElement, Int32? value)
  {
    openXmlElement.Pressure = value;
  }
  
  public static DMDraws.ArtisticMosaicBubbles? CreateModelElement(DXO2010Draw.ArtisticMosaicBubbles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticMosaicBubbles();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Pressure = GetPressure(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticMosaicBubbles? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticMosaicBubbles, new()
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
