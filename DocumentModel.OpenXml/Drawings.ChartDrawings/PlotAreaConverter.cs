namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
public static class PlotAreaConverter
{
  /// <summary>
  /// PlotAreaRegion.
  /// </summary>
  private static DMDrawsChartDraws.PlotAreaRegion? GetPlotAreaRegion(DXO2016DrawChartDraw.PlotArea openXmlElement)
  {
    return DMXDrawsChartDraws.PlotAreaRegionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PlotAreaRegion>());
  }
  
  private static bool CmpPlotAreaRegion(DXO2016DrawChartDraw.PlotArea openXmlElement, DMDrawsChartDraws.PlotAreaRegion? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.PlotAreaRegionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PlotAreaRegion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPlotAreaRegion(DXO2016DrawChartDraw.PlotArea openXmlElement, DMDrawsChartDraws.PlotAreaRegion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PlotAreaRegion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.PlotAreaRegionConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.PlotAreaRegion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsChartDraws.Axis> GetAxis(DXO2016DrawChartDraw.PlotArea openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.Axis>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.Axis>())
    {
      var newItem = DMXDrawsChartDraws.AxisConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpAxis(DXO2016DrawChartDraw.PlotArea openXmlElement, Collection<DMDrawsChartDraws.Axis>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetAxis(DXO2016DrawChartDraw.PlotArea openXmlElement, Collection<DMDrawsChartDraws.Axis>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.Axis>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.AxisConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Axis>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsChartDraws.ShapeProperties? GetShapeProperties(DXO2016DrawChartDraw.PlotArea openXmlElement)
  {
    return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXO2016DrawChartDraw.PlotArea openXmlElement, DMDrawsChartDraws.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXO2016DrawChartDraw.PlotArea openXmlElement, DMDrawsChartDraws.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ShapePropertiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.PlotArea openXmlElement)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.PlotArea openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.PlotArea openXmlElement, DMDrawsChartDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ExtensionListConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.PlotArea? CreateModelElement(DXO2016DrawChartDraw.PlotArea? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.PlotArea();
      value.PlotAreaRegion = GetPlotAreaRegion(openXmlElement);
      value.Axis = GetAxis(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.PlotArea? openXmlElement, DMDrawsChartDraws.PlotArea? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPlotAreaRegion(openXmlElement, value.PlotAreaRegion, diffs, objName))
        ok = false;
      if (!CmpAxis(openXmlElement, value.Axis, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.PlotArea? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.PlotArea, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPlotAreaRegion(openXmlElement, value?.PlotAreaRegion);
      SetAxis(openXmlElement, value?.Axis);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
