namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Ending Anchor Point.
/// </summary>
public static class ToAnchorConverter
{
  public static String? GetXPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition");
  }
  
  public static void SetXPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition");
  }
  
  public static String? GetYPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition");
  }
  
  public static void SetYPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition");
  }
  
  public static DocumentModel.Drawings.ChartDrawing.ToAnchor? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.ToAnchor();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.ToAnchor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
