namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public static class SeriesLayoutPropertiesConverter
{
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  private static DMDrawsChartDraws.ParentLabelLayout? GetParentLabelLayout(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ParentLabelLayout>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ParentLabelLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetParentLabelLayout(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.ParentLabelLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ParentLabelLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ParentLabelLayoutConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ParentLabelLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  private static DMDrawsChartDraws.RegionLabelLayoutEnum? GetRegionLabelLayout(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.RegionLabelLayout>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDrawsChartDraws.RegionLabelLayoutEnum>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetRegionLabelLayout(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.RegionLabelLayoutEnum? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.RegionLabelLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.RegionLabelLayout, DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDrawsChartDraws.RegionLabelLayoutEnum>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  private static DMDrawsChartDraws.SeriesElementVisibilities? GetSeriesElementVisibilities(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.SeriesElementVisibilities>();
    if (itemElement != null)
      return DMXDrawsChartDraws.SeriesElementVisibilitiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeriesElementVisibilities(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.SeriesElementVisibilities? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.SeriesElementVisibilities>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.SeriesElementVisibilitiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.SeriesElementVisibilities>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAggregation(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Aggregation>();
    return itemElement != null;
  }
  
  private static void SetAggregation(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Aggregation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2016DrawChartDraw.Aggregation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.Binning? GetBinning(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Binning>();
    if (itemElement != null)
      return DMXDrawsChartDraws.BinningConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBinning(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.Binning? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Binning>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.BinningConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Binning>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.Geography? GetGeography(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Geography>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeographyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeography(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.Geography? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Geography>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeographyConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Geography>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.Statistics? GetStatistics(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Statistics>();
    if (itemElement != null)
      return DMXDrawsChartDraws.StatisticsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStatistics(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.Statistics? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Statistics>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.StatisticsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Statistics>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.Subtotals? GetSubtotals(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Subtotals>();
    if (itemElement != null)
      return DMXDrawsChartDraws.SubtotalsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSubtotals(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.Subtotals? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Subtotals>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.SubtotalsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Subtotals>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DMDrawsChartDraws.SeriesLayoutProperties? CreateModelElement(DXO2016DrawChartDraw.SeriesLayoutProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.SeriesLayoutProperties();
      value.ParentLabelLayout = GetParentLabelLayout(openXmlElement);
      value.RegionLabelLayout = GetRegionLabelLayout(openXmlElement);
      value.SeriesElementVisibilities = GetSeriesElementVisibilities(openXmlElement);
      value.Aggregation = GetAggregation(openXmlElement);
      value.Binning = GetBinning(openXmlElement);
      value.Geography = GetGeography(openXmlElement);
      value.Statistics = GetStatistics(openXmlElement);
      value.Subtotals = GetSubtotals(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.SeriesLayoutProperties? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.SeriesLayoutProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParentLabelLayout(openXmlElement, value?.ParentLabelLayout);
      SetRegionLabelLayout(openXmlElement, value?.RegionLabelLayout);
      SetSeriesElementVisibilities(openXmlElement, value?.SeriesElementVisibilities);
      SetAggregation(openXmlElement, value?.Aggregation);
      SetBinning(openXmlElement, value?.Binning);
      SetGeography(openXmlElement, value?.Geography);
      SetStatistics(openXmlElement, value?.Statistics);
      SetSubtotals(openXmlElement, value?.Subtotals);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
