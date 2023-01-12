namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticWatercolorSponge Class.
/// </summary>
public static class ArtisticWatercolorSpongeConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  public static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetBrushSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge? openXmlElement)
  {
    return openXmlElement?.BrushSize?.Value;
  }
  
  public static void SetBrushSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.BrushSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticWatercolorSponge? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticWatercolorSponge();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.BrushSize = GetBrushSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticWatercolorSponge? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge, new()
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
