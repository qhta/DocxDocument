namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Shape Extent.
/// </summary>
public static class ExtentConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public static Int64? GetCx(DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent? openXmlElement)
  {
    return openXmlElement?.Cx?.Value;
  }
  
  public static void SetCx(DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public static Int64? GetCy(DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent? openXmlElement)
  {
    return openXmlElement?.Cy?.Value;
  }
  
  public static void SetCy(DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Cy = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawing.Extent? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.Extent();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.Extent? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
