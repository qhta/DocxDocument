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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ParentLabelLayout>();
    if (element != null)
      return DMXDrawsChartDraws.ParentLabelLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParentLabelLayout(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.ParentLabelLayout? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ParentLabelLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ParentLabelLayout>(), value, diffs, objName);
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDrawsChartDraws.RegionLabelLayoutEnum>(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.RegionLabelLayout>()?.Val?.Value);
  }
  
  private static bool CmpRegionLabelLayout(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.RegionLabelLayoutEnum? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDrawsChartDraws.RegionLabelLayoutEnum>(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.RegionLabelLayout>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetRegionLabelLayout(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.RegionLabelLayoutEnum? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.RegionLabelLayout>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDrawsChartDraws.RegionLabelLayoutEnum>(itemElement, (DMDrawsChartDraws.RegionLabelLayoutEnum)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.RegionLabelLayout, DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDrawsChartDraws.RegionLabelLayoutEnum>((DMDrawsChartDraws.RegionLabelLayoutEnum)value));
  }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  private static DMDrawsChartDraws.SeriesElementVisibilities? GetSeriesElementVisibilities(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.SeriesElementVisibilities>();
    if (element != null)
      return DMXDrawsChartDraws.SeriesElementVisibilitiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesElementVisibilities(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.SeriesElementVisibilities? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.SeriesElementVisibilitiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.SeriesElementVisibilities>(), value, diffs, objName);
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
    return openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Aggregation>() != null;
  }
  
  private static bool CmpAggregation(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Aggregation>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2016DrawChartDraw.Aggregation", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Binning>();
    if (element != null)
      return DMXDrawsChartDraws.BinningConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBinning(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.Binning? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.BinningConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Binning>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Geography>();
    if (element != null)
      return DMXDrawsChartDraws.GeographyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeography(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.Geography? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeographyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Geography>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Statistics>();
    if (element != null)
      return DMXDrawsChartDraws.StatisticsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStatistics(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.Statistics? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.StatisticsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Statistics>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Subtotals>();
    if (element != null)
      return DMXDrawsChartDraws.SubtotalsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubtotals(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.Subtotals? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.SubtotalsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Subtotals>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (element != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? CreateModelElement(DXO2016DrawChartDraw.SeriesLayoutProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties();
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.SeriesLayoutProperties? openXmlElement, DMDrawsChartDraws.SeriesLayoutProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpParentLabelLayout(openXmlElement, value.ParentLabelLayout, diffs, objName))
        ok = false;
      if (!CmpRegionLabelLayout(openXmlElement, value.RegionLabelLayout, diffs, objName))
        ok = false;
      if (!CmpSeriesElementVisibilities(openXmlElement, value.SeriesElementVisibilities, diffs, objName))
        ok = false;
      if (!CmpAggregation(openXmlElement, value.Aggregation, diffs, objName))
        ok = false;
      if (!CmpBinning(openXmlElement, value.Binning, diffs, objName))
        ok = false;
      if (!CmpGeography(openXmlElement, value.Geography, diffs, objName))
        ok = false;
      if (!CmpStatistics(openXmlElement, value.Statistics, diffs, objName))
        ok = false;
      if (!CmpSubtotals(openXmlElement, value.Subtotals, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.SeriesLayoutProperties value)
    where OpenXmlElementType: DXO2016DrawChartDraw.SeriesLayoutProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.SeriesLayoutProperties openXmlElement, DMDrawsChartDraws.SeriesLayoutProperties value)
  {
    SetParentLabelLayout(openXmlElement, value?.ParentLabelLayout);
    SetRegionLabelLayout(openXmlElement, value?.RegionLabelLayout);
    SetSeriesElementVisibilities(openXmlElement, value?.SeriesElementVisibilities);
    SetAggregation(openXmlElement, value?.Aggregation);
    SetBinning(openXmlElement, value?.Binning);
    SetGeography(openXmlElement, value?.Geography);
    SetStatistics(openXmlElement, value?.Statistics);
    SetSubtotals(openXmlElement, value?.Subtotals);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
