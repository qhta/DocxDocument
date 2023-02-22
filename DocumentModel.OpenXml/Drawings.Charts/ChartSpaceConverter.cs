namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Chart Space.
/// </summary>
public static class ChartSpaceConverter
{
  /// <summary>
  /// Date1904.
  /// </summary>
  private static Boolean? GetDate1904(DXDrawCharts.ChartSpace openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Date1904>() != null;
  }
  
  private static bool CmpDate1904(DXDrawCharts.ChartSpace openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Date1904>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Date1904", val, value);
    return false;
  }
  
  private static void SetDate1904(DXDrawCharts.ChartSpace openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Date1904>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Date1904();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EditingLanguage.
  /// </summary>
  private static String? GetEditingLanguage(DXDrawCharts.ChartSpace openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.EditingLanguage>()?.Val);
  }
  
  private static bool CmpEditingLanguage(DXDrawCharts.ChartSpace openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.EditingLanguage>()?.Val, value, diffs, objName, "EditingLanguage");
  }
  
  private static void SetEditingLanguage(DXDrawCharts.ChartSpace openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXDrawCharts.EditingLanguage>(openXmlElement, value);
  }
  
  /// <summary>
  /// RoundedCorners.
  /// </summary>
  private static Boolean? GetRoundedCorners(DXDrawCharts.ChartSpace openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.RoundedCorners>() != null;
  }
  
  private static bool CmpRoundedCorners(DXDrawCharts.ChartSpace openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.RoundedCorners>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.RoundedCorners", val, value);
    return false;
  }
  
  private static void SetRoundedCorners(DXDrawCharts.ChartSpace openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RoundedCorners>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.RoundedCorners();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Byte? GetStyle(DXDrawCharts.ChartSpace openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010DrawCharts.Style>()?.Val);
  }
  
  private static bool CmpStyle(DXDrawCharts.ChartSpace openXmlElement, Byte? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010DrawCharts.Style>()?.Val, value, diffs, objName, "Style2");
  }
  
  private static void SetStyle(DXDrawCharts.ChartSpace openXmlElement, Byte? value)
  {
    SimpleValueConverter.SetValue<DXO2010DrawCharts.Style,System.Byte>(openXmlElement, value);
  }
  
  private static DMDrawsCharts.ColorMapOverride? GetColorMapOverride(DXDrawCharts.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ColorMapOverride>();
    if (element != null)
      return DMXDrawsCharts.ColorMapOverrideConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorMapOverride(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ColorMapOverride? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ColorMapOverrideConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ColorMapOverride>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetColorMapOverride(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ColorMapOverride? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ColorMapOverride>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ColorMapOverrideConverter.CreateOpenXmlElement<DXDrawCharts.ColorMapOverride>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.PivotSource? GetPivotSource(DXDrawCharts.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.PivotSource>();
    if (element != null)
      return DMXDrawsCharts.PivotSourceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPivotSource(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.PivotSource? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PivotSourceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.PivotSource>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPivotSource(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.PivotSource? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PivotSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PivotSourceConverter.CreateOpenXmlElement<DXDrawCharts.PivotSource>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Protection? GetProtection(DXDrawCharts.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Protection>();
    if (element != null)
      return DMXDrawsCharts.ProtectionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpProtection(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.Protection? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ProtectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Protection>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetProtection(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.Protection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Protection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ProtectionConverter.CreateOpenXmlElement<DXDrawCharts.Protection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Chart? GetChart(DXDrawCharts.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Chart>();
    if (element != null)
      return DMXDrawsCharts.ChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChart(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.Chart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Chart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChart(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.Chart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Chart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartConverter.CreateOpenXmlElement<DXDrawCharts.Chart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ShapeProperties? GetShapeProperties(DXDrawCharts.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXDrawCharts.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>();
    if (element != null)
      return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.TextProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextProperties(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.TextPropertiesConverter.CreateOpenXmlElement<DXDrawCharts.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ExternalData? GetExternalData(DXDrawCharts.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExternalData>();
    if (element != null)
      return DMXDrawsCharts.ExternalDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExternalData(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ExternalData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExternalDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExternalData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExternalData(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ExternalData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExternalData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExternalDataConverter.CreateOpenXmlElement<DXDrawCharts.ExternalData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.PrintSettings? GetPrintSettings(DXDrawCharts.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.PrintSettings>();
    if (element != null)
      return DMXDrawsCharts.PrintSettingsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPrintSettings(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.PrintSettings? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PrintSettingsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.PrintSettings>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPrintSettings(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.PrintSettings? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PrintSettings>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PrintSettingsConverter.CreateOpenXmlElement<DXDrawCharts.PrintSettings>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.RelationshipIdType? GetUserShapesReference(DXDrawCharts.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.UserShapesReference>();
    if (element != null)
      return DMXDrawsCharts.RelationshipIdTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUserShapesReference(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.RelationshipIdType? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.RelationshipIdTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.UserShapesReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUserShapesReference(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.RelationshipIdType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.UserShapesReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.RelationshipIdTypeConverter.CreateOpenXmlElement<DXDrawCharts.UserShapesReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ChartSpaceExtensionList? GetChartSpaceExtensionList(DXDrawCharts.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ChartSpaceExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ChartSpaceExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartSpaceExtensionList(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ChartSpaceExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartSpaceExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartSpaceExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartSpaceExtensionList(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ChartSpaceExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartSpaceExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartSpaceExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ChartSpaceExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartSpace? CreateModelElement(DXDrawCharts.ChartSpace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartSpace();
      value.Date1904 = GetDate1904(openXmlElement);
      value.EditingLanguage = GetEditingLanguage(openXmlElement);
      value.RoundedCorners = GetRoundedCorners(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.ColorMapOverride = GetColorMapOverride(openXmlElement);
      value.PivotSource = GetPivotSource(openXmlElement);
      value.Protection = GetProtection(openXmlElement);
      value.Chart = GetChart(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.ExternalData = GetExternalData(openXmlElement);
      value.PrintSettings = GetPrintSettings(openXmlElement);
      value.UserShapesReference = GetUserShapesReference(openXmlElement);
      value.ChartSpaceExtensionList = GetChartSpaceExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ChartSpace? openXmlElement, DMDrawsCharts.ChartSpace? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDate1904(openXmlElement, value.Date1904, diffs, objName))
        ok = false;
      if (!CmpEditingLanguage(openXmlElement, value.EditingLanguage, diffs, objName))
        ok = false;
      if (!CmpRoundedCorners(openXmlElement, value.RoundedCorners, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      if (!CmpColorMapOverride(openXmlElement, value.ColorMapOverride, diffs, objName))
        ok = false;
      if (!CmpPivotSource(openXmlElement, value.PivotSource, diffs, objName))
        ok = false;
      if (!CmpProtection(openXmlElement, value.Protection, diffs, objName))
        ok = false;
      if (!CmpChart(openXmlElement, value.Chart, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName))
        ok = false;
      if (!CmpExternalData(openXmlElement, value.ExternalData, diffs, objName))
        ok = false;
      if (!CmpPrintSettings(openXmlElement, value.PrintSettings, diffs, objName))
        ok = false;
      if (!CmpUserShapesReference(openXmlElement, value.UserShapesReference, diffs, objName))
        ok = false;
      if (!CmpChartSpaceExtensionList(openXmlElement, value.ChartSpaceExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartSpace value)
    where OpenXmlElementType: DXDrawCharts.ChartSpace, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ChartSpace value)
  {
    SetDate1904(openXmlElement, value?.Date1904);
    SetEditingLanguage(openXmlElement, value?.EditingLanguage);
    SetRoundedCorners(openXmlElement, value?.RoundedCorners);
    SetStyle(openXmlElement, value?.Style);
    SetColorMapOverride(openXmlElement, value?.ColorMapOverride);
    SetPivotSource(openXmlElement, value?.PivotSource);
    SetProtection(openXmlElement, value?.Protection);
    SetChart(openXmlElement, value?.Chart);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetTextProperties(openXmlElement, value?.TextProperties);
    SetExternalData(openXmlElement, value?.ExternalData);
    SetPrintSettings(openXmlElement, value?.PrintSettings);
    SetUserShapesReference(openXmlElement, value?.UserShapesReference);
    SetChartSpaceExtensionList(openXmlElement, value?.ChartSpaceExtensionList);
    }
  }
