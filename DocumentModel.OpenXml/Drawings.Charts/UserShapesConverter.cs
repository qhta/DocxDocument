namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// User Shapes.
/// </summary>
public static class UserShapesConverter
{
  private static DMDrawsChartDraw.RelativeAnchorSize? GetRelativeAnchorSize(DXDrawCharts.UserShapes openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.RelativeAnchorSize>();
    if (element != null)
      return DMXDrawsChartDraw.RelativeAnchorSizeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRelativeAnchorSize(DXDrawCharts.UserShapes openXmlElement, DMDrawsChartDraw.RelativeAnchorSize? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.RelativeAnchorSizeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.RelativeAnchorSize>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.AbsoluteAnchorSize>();
    if (element != null)
      return DMXDrawsChartDraw.AbsoluteAnchorSizeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAbsoluteAnchorSize(DXDrawCharts.UserShapes openXmlElement, DMDrawsChartDraw.AbsoluteAnchorSize? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.AbsoluteAnchorSizeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.AbsoluteAnchorSize>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.Charts.UserShapes? CreateModelElement(DXDrawCharts.UserShapes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.UserShapes();
      value.RelativeAnchorSize = GetRelativeAnchorSize(openXmlElement);
      value.AbsoluteAnchorSize = GetAbsoluteAnchorSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.UserShapes? openXmlElement, DMDrawsCharts.UserShapes? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelativeAnchorSize(openXmlElement, value.RelativeAnchorSize, diffs, objName))
        ok = false;
      if (!CmpAbsoluteAnchorSize(openXmlElement, value.AbsoluteAnchorSize, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.UserShapes value)
    where OpenXmlElementType: DXDrawCharts.UserShapes, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.UserShapes openXmlElement, DMDrawsCharts.UserShapes value)
  {
    SetRelativeAnchorSize(openXmlElement, value?.RelativeAnchorSize);
    SetAbsoluteAnchorSize(openXmlElement, value?.AbsoluteAnchorSize);
    }
  }
