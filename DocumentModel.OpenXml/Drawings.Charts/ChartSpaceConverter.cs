namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Chart Space.
/// </summary>
public static class ChartSpaceConverter
{
  /// <summary>
  /// Date1904.
  /// </summary>
  private static Boolean? GetDate1904(DXDC.ChartSpace openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Date1904>() != null;
  }
  
  private static bool CmpDate1904(DXDC.ChartSpace openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Date1904>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Date1904", val, value);
    return false;
  }
  
  private static void SetDate1904(DXDC.ChartSpace openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Date1904>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Date1904();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// EditingLanguage.
  /// </summary>
  private static String? GetEditingLanguage(DXDC.ChartSpace openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.EditingLanguage>()?.Val);
  }
  
  private static bool CmpEditingLanguage(DXDC.ChartSpace openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.EditingLanguage>()?.Val, value, diffs, objName, "EditingLanguage");
  }
  
  private static void SetEditingLanguage(DXDC.ChartSpace openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXDC.EditingLanguage>(openXmlElement, value);
  }
  
  /// <summary>
  /// RoundedCorners.
  /// </summary>
  private static Boolean? GetRoundedCorners(DXDC.ChartSpace openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.RoundedCorners>() != null;
  }
  
  private static bool CmpRoundedCorners(DXDC.ChartSpace openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.RoundedCorners>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.RoundedCorners", val, value);
    return false;
  }
  
  private static void SetRoundedCorners(DXDC.ChartSpace openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.RoundedCorners>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.RoundedCorners();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Byte? GetStyle(DXDC.ChartSpace openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10DC.Style>()?.Val);
  }
  
  private static bool CmpStyle(DXDC.ChartSpace openXmlElement, Byte? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10DC.Style>()?.Val, value, diffs, objName, "Style2");
  }
  
  private static void SetStyle(DXDC.ChartSpace openXmlElement, Byte? value)
  {
    SimpleValueConverter.SetValue<DXO10DC.Style,System.Byte>(openXmlElement, value);
  }
  
  private static DMDC.ColorMapOverride? GetColorMapOverride(DXDC.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ColorMapOverride>();
    if (element != null)
      return DMXDC.ColorMapOverrideConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorMapOverride(DXDC.ChartSpace openXmlElement, DMDC.ColorMapOverride? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ColorMapOverrideConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ColorMapOverride>(), value, diffs, objName, propName);
  }
  
  private static void SetColorMapOverride(DXDC.ChartSpace openXmlElement, DMDC.ColorMapOverride? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ColorMapOverride>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ColorMapOverrideConverter.CreateOpenXmlElement<DXDC.ColorMapOverride>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.PivotSource? GetPivotSource(DXDC.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PivotSource>();
    if (element != null)
      return DMXDC.PivotSourceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPivotSource(DXDC.ChartSpace openXmlElement, DMDC.PivotSource? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.PivotSourceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PivotSource>(), value, diffs, objName, propName);
  }
  
  private static void SetPivotSource(DXDC.ChartSpace openXmlElement, DMDC.PivotSource? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PivotSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PivotSourceConverter.CreateOpenXmlElement<DXDC.PivotSource>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Protection? GetProtection(DXDC.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Protection>();
    if (element != null)
      return DMXDC.ProtectionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpProtection(DXDC.ChartSpace openXmlElement, DMDC.Protection? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ProtectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Protection>(), value, diffs, objName, propName);
  }
  
  private static void SetProtection(DXDC.ChartSpace openXmlElement, DMDC.Protection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Protection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ProtectionConverter.CreateOpenXmlElement<DXDC.Protection>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Chart? GetChart(DXDC.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Chart>();
    if (element != null)
      return DMXDC.ChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChart(DXDC.ChartSpace openXmlElement, DMDC.Chart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Chart>(), value, diffs, objName, propName);
  }
  
  private static void SetChart(DXDC.ChartSpace openXmlElement, DMDC.Chart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Chart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartConverter.CreateOpenXmlElement<DXDC.Chart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ShapeProperties? GetShapeProperties(DXDC.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ShapeProperties>();
    if (element != null)
      return DMXDC.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDC.ChartSpace openXmlElement, DMDC.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXDC.ChartSpace openXmlElement, DMDC.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ShapePropertiesConverter.CreateOpenXmlElement<DXDC.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.TextProperties? GetTextProperties(DXDC.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.TextProperties>();
    if (element != null)
      return DMXDC.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDC.ChartSpace openXmlElement, DMDC.TextProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.TextProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetTextProperties(DXDC.ChartSpace openXmlElement, DMDC.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.TextPropertiesConverter.CreateOpenXmlElement<DXDC.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ExternalData? GetExternalData(DXDC.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExternalData>();
    if (element != null)
      return DMXDC.ExternalDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExternalData(DXDC.ChartSpace openXmlElement, DMDC.ExternalData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExternalDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExternalData>(), value, diffs, objName, propName);
  }
  
  private static void SetExternalData(DXDC.ChartSpace openXmlElement, DMDC.ExternalData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExternalData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExternalDataConverter.CreateOpenXmlElement<DXDC.ExternalData>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.PrintSettings? GetPrintSettings(DXDC.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PrintSettings>();
    if (element != null)
      return DMXDC.PrintSettingsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPrintSettings(DXDC.ChartSpace openXmlElement, DMDC.PrintSettings? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.PrintSettingsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PrintSettings>(), value, diffs, objName, propName);
  }
  
  private static void SetPrintSettings(DXDC.ChartSpace openXmlElement, DMDC.PrintSettings? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PrintSettings>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PrintSettingsConverter.CreateOpenXmlElement<DXDC.PrintSettings>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.RelationshipIdType? GetUserShapesReference(DXDC.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.UserShapesReference>();
    if (element != null)
      return DMXDC.RelationshipIdTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUserShapesReference(DXDC.ChartSpace openXmlElement, DMDC.RelationshipIdType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.RelationshipIdTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.UserShapesReference>(), value, diffs, objName, propName);
  }
  
  private static void SetUserShapesReference(DXDC.ChartSpace openXmlElement, DMDC.RelationshipIdType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.UserShapesReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.RelationshipIdTypeConverter.CreateOpenXmlElement<DXDC.UserShapesReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ChartSpaceExtensionList? GetChartSpaceExtensionList(DXDC.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartSpaceExtensionList>();
    if (element != null)
      return DMXDC.ChartSpaceExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartSpaceExtensionList(DXDC.ChartSpace openXmlElement, DMDC.ChartSpaceExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartSpaceExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartSpaceExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetChartSpaceExtensionList(DXDC.ChartSpace openXmlElement, DMDC.ChartSpaceExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartSpaceExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartSpaceExtensionListConverter.CreateOpenXmlElement<DXDC.ChartSpaceExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.ChartSpace? CreateModelElement(DXDC.ChartSpace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.ChartSpace();
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
  
  public static bool CompareModelElement(DXDC.ChartSpace? openXmlElement, DMDC.ChartSpace? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDate1904(openXmlElement, value.Date1904, diffs, objName, propName))
        ok = false;
      if (!CmpEditingLanguage(openXmlElement, value.EditingLanguage, diffs, objName, propName))
        ok = false;
      if (!CmpRoundedCorners(openXmlElement, value.RoundedCorners, diffs, objName, propName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName, propName))
        ok = false;
      if (!CmpColorMapOverride(openXmlElement, value.ColorMapOverride, diffs, objName, propName))
        ok = false;
      if (!CmpPivotSource(openXmlElement, value.PivotSource, diffs, objName, propName))
        ok = false;
      if (!CmpProtection(openXmlElement, value.Protection, diffs, objName, propName))
        ok = false;
      if (!CmpChart(openXmlElement, value.Chart, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName, propName))
        ok = false;
      if (!CmpExternalData(openXmlElement, value.ExternalData, diffs, objName, propName))
        ok = false;
      if (!CmpPrintSettings(openXmlElement, value.PrintSettings, diffs, objName, propName))
        ok = false;
      if (!CmpUserShapesReference(openXmlElement, value.UserShapesReference, diffs, objName, propName))
        ok = false;
      if (!CmpChartSpaceExtensionList(openXmlElement, value.ChartSpaceExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ChartSpace value)
    where OpenXmlElementType: DXDC.ChartSpace, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ChartSpace openXmlElement, DMDC.ChartSpace value)
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
