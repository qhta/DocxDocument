namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public static class MarkerTypeConverter
{
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  public static String? GetXPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition");
  }
  
  public static void SetXPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition");
  }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  public static String? GetYPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition");
  }
  
  public static void SetYPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition");
  }
  
  public static DocumentModel.Drawings.ChartDrawing.MarkerType? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.MarkerType();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.MarkerType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
