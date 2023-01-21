namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticCement Class.
/// </summary>
public static class ArtisticCementConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticCement openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticCement openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetCrackSpacing(DXO2010Draw.ArtisticCement openXmlElement)
  {
    return openXmlElement.CrackSpacing?.Value;
  }
  
  private static void SetCrackSpacing(DXO2010Draw.ArtisticCement openXmlElement, Int32? value)
  {
    openXmlElement.CrackSpacing = value;
  }
  
  public static DMDraws.ArtisticCement? CreateModelElement(DXO2010Draw.ArtisticCement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticCement();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.CrackSpacing = GetCrackSpacing(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticCement? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticCement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetCrackSpacing(openXmlElement, value?.CrackSpacing);
      return openXmlElement;
    }
    return default;
  }
}
