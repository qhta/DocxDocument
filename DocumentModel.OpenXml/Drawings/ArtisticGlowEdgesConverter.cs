namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticGlowEdges Class.
/// </summary>
public static class ArtisticGlowEdgesConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticGlowEdges openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticGlowEdges openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSmoothness(DXO2010Draw.ArtisticGlowEdges openXmlElement)
  {
    return openXmlElement.Smoothness?.Value;
  }
  
  private static void SetSmoothness(DXO2010Draw.ArtisticGlowEdges openXmlElement, Int32? value)
  {
    openXmlElement.Smoothness = value;
  }
  
  public static DMDraws.ArtisticGlowEdges? CreateModelElement(DXO2010Draw.ArtisticGlowEdges? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticGlowEdges();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Smoothness = GetSmoothness(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticGlowEdges? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticGlowEdges, new()
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
