namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Starting Anchor Point.
/// </summary>
public static class FromAnchorConverter
{
  public static String? GetXPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition");
  }
  
  public static void SetXPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition");
  }
  
  public static String? GetYPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition");
  }
  
  public static void SetYPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition");
  }
  
  public static DocumentModel.Drawings.ChartDrawing.FromAnchor? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.FromAnchor();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.FromAnchor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
