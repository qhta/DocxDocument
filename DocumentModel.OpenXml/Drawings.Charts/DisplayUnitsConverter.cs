namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public static class DisplayUnitsConverter
{
  private static Double? GetCustomDisplayUnit(DXDrawCharts.DisplayUnits openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.CustomDisplayUnit>()?.Val);
  }
  
  private static bool CmpCustomDisplayUnit(DXDrawCharts.DisplayUnits openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.CustomDisplayUnit>()?.Val, value, diffs, objName, "CustomDisplayUnit");
  }
  
  private static void SetCustomDisplayUnit(DXDrawCharts.DisplayUnits openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.CustomDisplayUnit,System.Double>(openXmlElement, value);
  }
  
  private static DMDrawsCharts.BuiltInUnitKind? GetBuiltInUnit(DXDrawCharts.DisplayUnits openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDrawsCharts.BuiltInUnitKind>(openXmlElement.GetFirstChild<DXDrawCharts.BuiltInUnit>()?.Val?.Value);
  }
  
  private static bool CmpBuiltInUnit(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.BuiltInUnitKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDrawsCharts.BuiltInUnitKind>(openXmlElement.GetFirstChild<DXDrawCharts.BuiltInUnit>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBuiltInUnit(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.BuiltInUnitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BuiltInUnit>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDrawsCharts.BuiltInUnitKind>(itemElement, (DMDrawsCharts.BuiltInUnitKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.BuiltInUnit, DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDrawsCharts.BuiltInUnitKind>((DMDrawsCharts.BuiltInUnitKind)value));
  }
  
  private static DMDrawsCharts.DisplayUnitsLabel? GetDisplayUnitsLabel(DXDrawCharts.DisplayUnits openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DisplayUnitsLabel>();
    if (element != null)
      return DMXDrawsCharts.DisplayUnitsLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDisplayUnitsLabel(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.DisplayUnitsLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DisplayUnitsLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DisplayUnitsLabel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDisplayUnitsLabel(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.DisplayUnitsLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DisplayUnitsLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DisplayUnitsLabelConverter.CreateOpenXmlElement<DXDrawCharts.DisplayUnitsLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.DisplayUnits openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DisplayUnits? CreateModelElement(DXDrawCharts.DisplayUnits? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DisplayUnits();
      value.CustomDisplayUnit = GetCustomDisplayUnit(openXmlElement);
      value.BuiltInUnit = GetBuiltInUnit(openXmlElement);
      value.DisplayUnitsLabel = GetDisplayUnitsLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.DisplayUnits? openXmlElement, DMDrawsCharts.DisplayUnits? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCustomDisplayUnit(openXmlElement, value.CustomDisplayUnit, diffs, objName))
        ok = false;
      if (!CmpBuiltInUnit(openXmlElement, value.BuiltInUnit, diffs, objName))
        ok = false;
      if (!CmpDisplayUnitsLabel(openXmlElement, value.DisplayUnitsLabel, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DisplayUnits value)
    where OpenXmlElementType: DXDrawCharts.DisplayUnits, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.DisplayUnits value)
  {
    SetCustomDisplayUnit(openXmlElement, value?.CustomDisplayUnit);
    SetBuiltInUnit(openXmlElement, value?.BuiltInUnit);
    SetDisplayUnitsLabel(openXmlElement, value?.DisplayUnitsLabel);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
