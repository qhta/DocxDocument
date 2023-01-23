namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public static class DisplayUnitsConverter
{
  private static Double? GetCustomDisplayUnit(DXDrawCharts.DisplayUnits openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.CustomDisplayUnit>()?.Val?.Value;
  }
  
  private static bool CmpCustomDisplayUnit(DXDrawCharts.DisplayUnits openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.CustomDisplayUnit>()?.Val?.Value == value;
  }
  
  private static void SetCustomDisplayUnit(DXDrawCharts.DisplayUnits openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.CustomDisplayUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.CustomDisplayUnit{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
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
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.BuiltInUnit, DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDrawsCharts.BuiltInUnitKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.DisplayUnitsLabel? GetDisplayUnitsLabel(DXDrawCharts.DisplayUnits openXmlElement)
  {
    return DMXDrawsCharts.DisplayUnitsLabelConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DisplayUnitsLabel>());
  }
  
  private static bool CmpDisplayUnitsLabel(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.DisplayUnitsLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DisplayUnitsLabelConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DisplayUnitsLabel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMDrawsCharts.DisplayUnits? CreateModelElement(DXDrawCharts.DisplayUnits? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DisplayUnits();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DisplayUnits? value)
    where OpenXmlElementType: DXDrawCharts.DisplayUnits, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomDisplayUnit(openXmlElement, value?.CustomDisplayUnit);
      SetBuiltInUnit(openXmlElement, value?.BuiltInUnit);
      SetDisplayUnitsLabel(openXmlElement, value?.DisplayUnitsLabel);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
