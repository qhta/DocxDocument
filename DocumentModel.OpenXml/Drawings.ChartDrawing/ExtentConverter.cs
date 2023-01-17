namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Shape Extent.
/// </summary>
public static class ExtentConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  private static Int64? GetCx(DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent openXmlElement)
  {
    return openXmlElement.Cx?.Value;
  }
  
  private static void SetCx(DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  private static Int64? GetCy(DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent openXmlElement)
  {
    return openXmlElement.Cy?.Value;
  }
  
  private static void SetCy(DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent openXmlElement, Int64? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCx(openXmlElement, value?.Cx);
      SetCy(openXmlElement, value?.Cy);
      return openXmlElement;
    }
    return default;
  }
}
