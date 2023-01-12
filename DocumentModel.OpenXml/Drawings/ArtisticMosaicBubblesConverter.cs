namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticMosaicBubbles Class.
/// </summary>
public static class ArtisticMosaicBubblesConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  public static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetPressure(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles? openXmlElement)
  {
    return openXmlElement?.Pressure?.Value;
  }
  
  public static void SetPressure(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pressure = value;
  }
  
  public static DocumentModel.Drawings.ArtisticMosaicBubbles? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticMosaicBubbles();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Pressure = GetPressure(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticMosaicBubbles? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles, new()
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
