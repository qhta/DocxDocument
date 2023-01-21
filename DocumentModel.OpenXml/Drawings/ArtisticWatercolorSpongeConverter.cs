namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticWatercolorSponge Class.
/// </summary>
public static class ArtisticWatercolorSpongeConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticWatercolorSponge openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticWatercolorSponge openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetBrushSize(DXO2010Draw.ArtisticWatercolorSponge openXmlElement)
  {
    return openXmlElement.BrushSize?.Value;
  }
  
  private static void SetBrushSize(DXO2010Draw.ArtisticWatercolorSponge openXmlElement, Int32? value)
  {
    openXmlElement.BrushSize = value;
  }
  
  public static DMDraws.ArtisticWatercolorSponge? CreateModelElement(DXO2010Draw.ArtisticWatercolorSponge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticWatercolorSponge();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.BrushSize = GetBrushSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticWatercolorSponge? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticWatercolorSponge, new()
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
