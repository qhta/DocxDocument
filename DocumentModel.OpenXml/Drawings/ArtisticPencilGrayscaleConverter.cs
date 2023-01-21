namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPencilGrayscale Class.
/// </summary>
public static class ArtisticPencilGrayscaleConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticPencilGrayscale openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticPencilGrayscale openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetBrushSize(DXO2010Draw.ArtisticPencilGrayscale openXmlElement)
  {
    return openXmlElement.BrushSize?.Value;
  }
  
  private static void SetBrushSize(DXO2010Draw.ArtisticPencilGrayscale openXmlElement, Int32? value)
  {
    openXmlElement.BrushSize = value;
  }
  
  public static DMDraws.ArtisticPencilGrayscale? CreateModelElement(DXO2010Draw.ArtisticPencilGrayscale? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticPencilGrayscale();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.BrushSize = GetBrushSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticPencilGrayscale? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticPencilGrayscale, new()
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
