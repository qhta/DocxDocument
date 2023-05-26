namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Scaling.
/// </summary>
public static class ScalingConverter
{
  /// <summary>
  /// Logarithmic Base.
  /// </summary>
  private static Double? GetLogBase(DXDC.Scaling openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.LogBase>()?.Val);
  }
  
  private static bool CmpLogBase(DXDC.Scaling openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.LogBase>()?.Val, value, diffs, objName, "LogBase");
  }
  
  private static void SetLogBase(DXDC.Scaling openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.LogBase,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  private static DMDC.OrientationKind? GetOrientation(DXDC.Scaling openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDC.OrientationKind>(openXmlElement.GetFirstChild<DXDC.Orientation>()?.Val?.Value);
  }
  
  private static bool CmpOrientation(DXDC.Scaling openXmlElement, DMDC.OrientationKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDC.OrientationKind>(openXmlElement.GetFirstChild<DXDC.Orientation>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetOrientation(DXDC.Scaling openXmlElement, DMDC.OrientationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Orientation>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDC.OrientationKind>(itemElement, (DMDC.OrientationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Orientation, DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDC.OrientationKind>((DMDC.OrientationKind)value));
  }
  
  /// <summary>
  /// Maximum.
  /// </summary>
  private static Double? GetMaxAxisValue(DXDC.Scaling openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.MaxAxisValue>()?.Val);
  }
  
  private static bool CmpMaxAxisValue(DXDC.Scaling openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.MaxAxisValue>()?.Val, value, diffs, objName, "MaxAxisValue");
  }
  
  private static void SetMaxAxisValue(DXDC.Scaling openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.MaxAxisValue,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Minimum.
  /// </summary>
  private static Double? GetMinAxisValue(DXDC.Scaling openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.MinAxisValue>()?.Val);
  }
  
  private static bool CmpMinAxisValue(DXDC.Scaling openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.MinAxisValue>()?.Val, value, diffs, objName, "MinAxisValue");
  }
  
  private static void SetMinAxisValue(DXDC.Scaling openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.MinAxisValue,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.Scaling openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.Scaling openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.Scaling openXmlElement, DMDC.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.Scaling? CreateModelElement(DXDC.Scaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Scaling();
      value.LogBase = GetLogBase(openXmlElement);
      value.Orientation = GetOrientation(openXmlElement);
      value.MaxAxisValue = GetMaxAxisValue(openXmlElement);
      value.MinAxisValue = GetMinAxisValue(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Scaling? openXmlElement, DMDC.Scaling? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLogBase(openXmlElement, value.LogBase, diffs, objName, propName))
        ok = false;
      if (!CmpOrientation(openXmlElement, value.Orientation, diffs, objName, propName))
        ok = false;
      if (!CmpMaxAxisValue(openXmlElement, value.MaxAxisValue, diffs, objName, propName))
        ok = false;
      if (!CmpMinAxisValue(openXmlElement, value.MinAxisValue, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Scaling value)
    where OpenXmlElementType: DXDC.Scaling, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Scaling openXmlElement, DMDC.Scaling value)
  {
    SetLogBase(openXmlElement, value?.LogBase);
    SetOrientation(openXmlElement, value?.Orientation);
    SetMaxAxisValue(openXmlElement, value?.MaxAxisValue);
    SetMinAxisValue(openXmlElement, value?.MinAxisValue);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
