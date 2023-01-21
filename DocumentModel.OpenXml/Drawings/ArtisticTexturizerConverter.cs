namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticTexturizer Class.
/// </summary>
public static class ArtisticTexturizerConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticTexturizer openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticTexturizer openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// scaling, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetScaling(DXO2010Draw.ArtisticTexturizer openXmlElement)
  {
    return openXmlElement.Scaling?.Value;
  }
  
  private static void SetScaling(DXO2010Draw.ArtisticTexturizer openXmlElement, Int32? value)
  {
    openXmlElement.Scaling = value;
  }
  
  public static DMDraws.ArtisticTexturizer? CreateModelElement(DXO2010Draw.ArtisticTexturizer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticTexturizer();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Scaling = GetScaling(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticTexturizer? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticTexturizer, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetScaling(openXmlElement, value?.Scaling);
      return openXmlElement;
    }
    return default;
  }
}
