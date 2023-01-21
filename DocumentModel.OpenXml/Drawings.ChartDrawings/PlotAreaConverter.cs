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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PlotAreaRegion>();
    if (itemElement != null)
      return DMXDrawsChartDraws.PlotAreaRegionConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static Collection<DMDrawsChartDraws.Axis> GetAxises(DXO2016DrawChartDraw.PlotArea openXmlElement)
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
  
  private static void SetAxises(DXO2016DrawChartDraw.PlotArea openXmlElement, Collection<DMDrawsChartDraws.Axis>? value)
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
      value.Axises = GetAxises(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.PlotArea? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.PlotArea, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPlotAreaRegion(openXmlElement, value?.PlotAreaRegion);
      SetAxises(openXmlElement, value?.Axises);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
