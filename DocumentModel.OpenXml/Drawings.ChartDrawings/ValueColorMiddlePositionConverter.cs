namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColorMiddlePosition Class.
/// </summary>
public static class ValueColorMiddlePositionConverter
{
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  public static Double? GetNumberColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition");
  }
  
  public static void SetNumberColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition");
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public static Double? GetPercentageColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition");
  }
  
  public static void SetPercentageColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition();
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
