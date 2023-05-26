namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public static class DisplayUnitsConverter
{
  private static Double? GetCustomDisplayUnit(DXDC.DisplayUnits openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.CustomDisplayUnit>()?.Val);
  }
  
  private static bool CmpCustomDisplayUnit(DXDC.DisplayUnits openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.CustomDisplayUnit>()?.Val, value, diffs, objName, "CustomDisplayUnit");
  }
  
  private static void SetCustomDisplayUnit(DXDC.DisplayUnits openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.CustomDisplayUnit,System.Double>(openXmlElement, value);
  }
  
  private static DMDC.BuiltInUnitKind? GetBuiltInUnit(DXDC.DisplayUnits openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDC.BuiltInUnitKind>(openXmlElement.GetFirstChild<DXDC.BuiltInUnit>()?.Val?.Value);
  }
  
  private static bool CmpBuiltInUnit(DXDC.DisplayUnits openXmlElement, DMDC.BuiltInUnitKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDC.BuiltInUnitKind>(openXmlElement.GetFirstChild<DXDC.BuiltInUnit>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetBuiltInUnit(DXDC.DisplayUnits openXmlElement, DMDC.BuiltInUnitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BuiltInUnit>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDC.BuiltInUnitKind>(itemElement, (DMDC.BuiltInUnitKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.BuiltInUnit, DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDC.BuiltInUnitKind>((DMDC.BuiltInUnitKind)value));
  }
  
  private static DMDC.DisplayUnitsLabel? GetDisplayUnitsLabel(DXDC.DisplayUnits openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DisplayUnitsLabel>();
    if (element != null)
      return DMXDC.DisplayUnitsLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDisplayUnitsLabel(DXDC.DisplayUnits openXmlElement, DMDC.DisplayUnitsLabel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DisplayUnitsLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DisplayUnitsLabel>(), value, diffs, objName, propName);
  }
  
  private static void SetDisplayUnitsLabel(DXDC.DisplayUnits openXmlElement, DMDC.DisplayUnitsLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DisplayUnitsLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DisplayUnitsLabelConverter.CreateOpenXmlElement<DXDC.DisplayUnitsLabel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ExtensionList? GetExtensionList(DXDC.DisplayUnits openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.DisplayUnits openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.DisplayUnits openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DisplayUnits? CreateModelElement(DXDC.DisplayUnits? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.DisplayUnits? openXmlElement, DMDC.DisplayUnits? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCustomDisplayUnit(openXmlElement, value.CustomDisplayUnit, diffs, objName, propName))
        ok = false;
      if (!CmpBuiltInUnit(openXmlElement, value.BuiltInUnit, diffs, objName, propName))
        ok = false;
      if (!CmpDisplayUnitsLabel(openXmlElement, value.DisplayUnitsLabel, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DisplayUnits value)
    where OpenXmlElementType: DXDC.DisplayUnits, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DisplayUnits openXmlElement, DMDC.DisplayUnits value)
  {
    SetCustomDisplayUnit(openXmlElement, value?.CustomDisplayUnit);
    SetBuiltInUnit(openXmlElement, value?.BuiltInUnit);
    SetDisplayUnitsLabel(openXmlElement, value?.DisplayUnitsLabel);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
