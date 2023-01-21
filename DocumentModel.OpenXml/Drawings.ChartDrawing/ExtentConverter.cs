namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Shape Extent.
/// </summary>
public static class ExtentConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  private static Int64? GetCx(DXDrawChartDraw.Extent openXmlElement)
  {
    return openXmlElement.Cx?.Value;
  }
  
  private static void SetCx(DXDrawChartDraw.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  private static Int64? GetCy(DXDrawChartDraw.Extent openXmlElement)
  {
    return openXmlElement.Cy?.Value;
  }
  
  private static void SetCy(DXDrawChartDraw.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cy = value;
  }
  
  public static DMDrawsChartDraw.Extent? CreateModelElement(DXDrawChartDraw.Extent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.Extent();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.Extent? value)
    where OpenXmlElementType: DXDrawChartDraw.Extent, new()
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
