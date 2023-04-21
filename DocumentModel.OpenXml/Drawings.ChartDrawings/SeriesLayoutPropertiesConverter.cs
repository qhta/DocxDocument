namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public static class SeriesLayoutPropertiesConverter
{
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  private static DMDCDs.ParentLabelLayout? GetParentLabelLayout(DXO16DCD.SeriesLayoutProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ParentLabelLayout>();
    if (element != null)
      return DMXDCDs.ParentLabelLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParentLabelLayout(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.ParentLabelLayout? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ParentLabelLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ParentLabelLayout>(), value, diffs, objName);
  }
  
  private static void SetParentLabelLayout(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.ParentLabelLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ParentLabelLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ParentLabelLayoutConverter.CreateOpenXmlElement<DXO16DCD.ParentLabelLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  private static DMDCDs.RegionLabelLayoutEnum? GetRegionLabelLayout(DXO16DCD.SeriesLayoutProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDCDs.RegionLabelLayoutEnum>(openXmlElement.GetFirstChild<DXO16DCD.RegionLabelLayout>()?.Val?.Value);
  }
  
  private static bool CmpRegionLabelLayout(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.RegionLabelLayoutEnum? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDCDs.RegionLabelLayoutEnum>(openXmlElement.GetFirstChild<DXO16DCD.RegionLabelLayout>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetRegionLabelLayout(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.RegionLabelLayoutEnum? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.RegionLabelLayout>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDCDs.RegionLabelLayoutEnum>(itemElement, (DMDCDs.RegionLabelLayoutEnum)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO16DCD.RegionLabelLayout, DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDCDs.RegionLabelLayoutEnum>((DMDCDs.RegionLabelLayoutEnum)value));
  }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  private static DMDCDs.SeriesElementVisibilities? GetSeriesElementVisibilities(DXO16DCD.SeriesLayoutProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.SeriesElementVisibilities>();
    if (element != null)
      return DMXDCDs.SeriesElementVisibilitiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesElementVisibilities(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.SeriesElementVisibilities? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.SeriesElementVisibilitiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.SeriesElementVisibilities>(), value, diffs, objName);
  }
  
  private static void SetSeriesElementVisibilities(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.SeriesElementVisibilities? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.SeriesElementVisibilities>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.SeriesElementVisibilitiesConverter.CreateOpenXmlElement<DXO16DCD.SeriesElementVisibilities>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAggregation(DXO16DCD.SeriesLayoutProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO16DCD.Aggregation>() != null;
  }
  
  private static bool CmpAggregation(DXO16DCD.SeriesLayoutProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO16DCD.Aggregation>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO16DCD.Aggregation", val, value);
    return false;
  }
  
  private static void SetAggregation(DXO16DCD.SeriesLayoutProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Aggregation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO16DCD.Aggregation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDCDs.Binning? GetBinning(DXO16DCD.SeriesLayoutProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Binning>();
    if (element != null)
      return DMXDCDs.BinningConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBinning(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.Binning? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.BinningConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Binning>(), value, diffs, objName);
  }
  
  private static void SetBinning(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.Binning? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Binning>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.BinningConverter.CreateOpenXmlElement<DXO16DCD.Binning>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDCDs.Geography? GetGeography(DXO16DCD.SeriesLayoutProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Geography>();
    if (element != null)
      return DMXDCDs.GeographyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeography(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.Geography? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.GeographyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Geography>(), value, diffs, objName);
  }
  
  private static void SetGeography(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.Geography? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Geography>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeographyConverter.CreateOpenXmlElement<DXO16DCD.Geography>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDCDs.Statistics? GetStatistics(DXO16DCD.SeriesLayoutProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Statistics>();
    if (element != null)
      return DMXDCDs.StatisticsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStatistics(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.Statistics? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.StatisticsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Statistics>(), value, diffs, objName);
  }
  
  private static void SetStatistics(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.Statistics? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Statistics>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.StatisticsConverter.CreateOpenXmlElement<DXO16DCD.Statistics>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDCDs.Subtotals? GetSubtotals(DXO16DCD.SeriesLayoutProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Subtotals>();
    if (element != null)
      return DMXDCDs.SubtotalsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubtotals(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.Subtotals? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.SubtotalsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Subtotals>(), value, diffs, objName);
  }
  
  private static void SetSubtotals(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.Subtotals? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Subtotals>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.SubtotalsConverter.CreateOpenXmlElement<DXO16DCD.Subtotals>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.SeriesLayoutProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? CreateModelElement(DXO16DCD.SeriesLayoutProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXO16DCD.SeriesLayoutProperties? openXmlElement, DMDCDs.SeriesLayoutProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.SeriesLayoutProperties value)
    where OpenXmlElementType: DXO16DCD.SeriesLayoutProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.SeriesLayoutProperties openXmlElement, DMDCDs.SeriesLayoutProperties value)
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
