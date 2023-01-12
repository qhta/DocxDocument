namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticLightScreen Class.
/// </summary>
public static class ArtisticLightScreenConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  public static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// gridSize, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetGridSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen? openXmlElement)
  {
    return openXmlElement?.GridSize?.Value;
  }
  
  public static void SetGridSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.GridSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticLightScreen? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticLightScreen();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.GridSize = GetGridSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticLightScreen? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetGridSize(openXmlElement, value?.GridSize);
      return openXmlElement;
    }
    return default;
  }
}
