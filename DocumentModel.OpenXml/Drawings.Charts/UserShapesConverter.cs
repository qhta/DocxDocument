namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// User Shapes.
/// </summary>
public static class UserShapesConverter
{
  private static DMDrawsChartDraw.RelativeAnchorSize? GetRelativeAnchorSize(DXDrawCharts.UserShapes openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.RelativeAnchorSize>();
    if (itemElement != null)
      return DMXDrawsChartDraw.RelativeAnchorSizeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRelativeAnchorSize(DXDrawCharts.UserShapes openXmlElement, DMDrawsChartDraw.RelativeAnchorSize? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.RelativeAnchorSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.RelativeAnchorSizeConverter.CreateOpenXmlElement<DXDrawChartDraw.RelativeAnchorSize>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraw.AbsoluteAnchorSize? GetAbsoluteAnchorSize(DXDrawCharts.UserShapes openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.AbsoluteAnchorSize>();
    if (itemElement != null)
      return DMXDrawsChartDraw.AbsoluteAnchorSizeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAbsoluteAnchorSize(DXDrawCharts.UserShapes openXmlElement, DMDrawsChartDraw.AbsoluteAnchorSize? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.AbsoluteAnchorSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.AbsoluteAnchorSizeConverter.CreateOpenXmlElement<DXDrawChartDraw.AbsoluteAnchorSize>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.UserShapes? CreateModelElement(DXDrawCharts.UserShapes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.UserShapes();
      value.RelativeAnchorSize = GetRelativeAnchorSize(openXmlElement);
      value.AbsoluteAnchorSize = GetAbsoluteAnchorSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.UserShapes? value)
    where OpenXmlElementType: DXDrawCharts.UserShapes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelativeAnchorSize(openXmlElement, value?.RelativeAnchorSize);
      SetAbsoluteAnchorSize(openXmlElement, value?.AbsoluteAnchorSize);
      return openXmlElement;
    }
    return default;
  }
}
