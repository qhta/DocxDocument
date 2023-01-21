namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPastelsSmooth Class.
/// </summary>
public static class ArtisticPastelsSmoothConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticPastelsSmooth openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticPastelsSmooth openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// scaling, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetBrushSize(DXO2010Draw.ArtisticPastelsSmooth openXmlElement)
  {
    return openXmlElement.BrushSize?.Value;
  }
  
  private static void SetBrushSize(DXO2010Draw.ArtisticPastelsSmooth openXmlElement, Int32? value)
  {
    openXmlElement.BrushSize = value;
  }
  
  public static DMDraws.ArtisticPastelsSmooth? CreateModelElement(DXO2010Draw.ArtisticPastelsSmooth? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticPastelsSmooth();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.BrushSize = GetBrushSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticPastelsSmooth? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticPastelsSmooth, new()
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
