namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  /// ChartTitle.
  /// </summary>
  private static DMDrawsChartDraws.ChartTitle? GetChartTitle(DXO2016DrawChartDraw.Chart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ChartTitle>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ChartTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartTitle(DXO2016DrawChartDraw.Chart openXmlElement, DMDrawsChartDraws.ChartTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ChartTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ChartTitleConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ChartTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  private static DMDrawsChartDraws.PlotArea? GetPlotArea(DXO2016DrawChartDraw.Chart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PlotArea>();
    if (itemElement != null)
      return DMXDrawsChartDraws.PlotAreaConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPlotArea(DXO2016DrawChartDraw.Chart openXmlElement, DMDrawsChartDraws.PlotArea? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PlotArea>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.PlotAreaConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.PlotArea>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Legend.
  /// </summary>
  private static DMDrawsChartDraws.Legend? GetLegend(DXO2016DrawChartDraw.Chart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Legend>();
    if (itemElement != null)
      return DMXDrawsChartDraws.LegendConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLegend(DXO2016DrawChartDraw.Chart openXmlElement, DMDrawsChartDraws.Legend? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Legend>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.LegendConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Legend>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.Chart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.Chart openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DMDrawsChartDraws.Chart? CreateModelElement(DXO2016DrawChartDraw.Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Chart();
      value.ChartTitle = GetChartTitle(openXmlElement);
      value.PlotArea = GetPlotArea(openXmlElement);
      value.Legend = GetLegend(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Chart? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Chart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartTitle(openXmlElement, value?.ChartTitle);
      SetPlotArea(openXmlElement, value?.PlotArea);
      SetLegend(openXmlElement, value?.Legend);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
