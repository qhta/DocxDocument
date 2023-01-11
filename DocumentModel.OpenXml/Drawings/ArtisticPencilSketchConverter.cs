namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPencilSketch Class.
/// </summary>
public static class ArtisticPencilSketchConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  public static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetPressure(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch? openXmlElement)
  {
    return openXmlElement?.Pressure?.Value;
  }
  
  public static void SetPressure(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pressure = value;
  }
  
  public static DocumentModel.Drawings.ArtisticPencilSketch? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPencilSketch();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Pressure = GetPressure(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticPencilSketch? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
