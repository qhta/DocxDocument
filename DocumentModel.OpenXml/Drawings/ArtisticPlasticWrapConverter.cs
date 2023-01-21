namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPlasticWrap Class.
/// </summary>
public static class ArtisticPlasticWrapConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticPlasticWrap openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticPlasticWrap openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSmoothness(DXO2010Draw.ArtisticPlasticWrap openXmlElement)
  {
    return openXmlElement.Smoothness?.Value;
  }
  
  private static void SetSmoothness(DXO2010Draw.ArtisticPlasticWrap openXmlElement, Int32? value)
  {
    openXmlElement.Smoothness = value;
  }
  
  public static DMDraws.ArtisticPlasticWrap? CreateModelElement(DXO2010Draw.ArtisticPlasticWrap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticPlasticWrap();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Smoothness = GetSmoothness(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticPlasticWrap? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticPlasticWrap, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetSmoothness(openXmlElement, value?.Smoothness);
      return openXmlElement;
    }
    return default;
  }
}
