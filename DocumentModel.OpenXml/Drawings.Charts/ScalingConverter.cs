namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Scaling.
/// </summary>
public static class ScalingConverter
{
  /// <summary>
  /// Logarithmic Base.
  /// </summary>
  private static Double? GetLogBase(DXDrawCharts.Scaling openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.LogBase>()?.Val);
  }
  
  private static bool CmpLogBase(DXDrawCharts.Scaling openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.LogBase>()?.Val, value, diffs, objName, "LogBase");
  }
  
  private static void SetLogBase(DXDrawCharts.Scaling openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.LogBase,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  private static DMDrawsCharts.OrientationKind? GetOrientation(DXDrawCharts.Scaling openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDrawsCharts.OrientationKind>(openXmlElement.GetFirstChild<DXDrawCharts.Orientation>()?.Val?.Value);
  }
  
  private static bool CmpOrientation(DXDrawCharts.Scaling openXmlElement, DMDrawsCharts.OrientationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDrawsCharts.OrientationKind>(openXmlElement.GetFirstChild<DXDrawCharts.Orientation>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOrientation(DXDrawCharts.Scaling openXmlElement, DMDrawsCharts.OrientationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Orientation>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDrawsCharts.OrientationKind>(itemElement, (DMDrawsCharts.OrientationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.Orientation, DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DMDrawsCharts.OrientationKind>((DMDrawsCharts.OrientationKind)value));
  }
  
  /// <summary>
  /// Maximum.
  /// </summary>
  private static Double? GetMaxAxisValue(DXDrawCharts.Scaling openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.MaxAxisValue>()?.Val);
  }
  
  private static bool CmpMaxAxisValue(DXDrawCharts.Scaling openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.MaxAxisValue>()?.Val, value, diffs, objName, "MaxAxisValue");
  }
  
  private static void SetMaxAxisValue(DXDrawCharts.Scaling openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.MaxAxisValue,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Minimum.
  /// </summary>
  private static Double? GetMinAxisValue(DXDrawCharts.Scaling openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.MinAxisValue>()?.Val);
  }
  
  private static bool CmpMinAxisValue(DXDrawCharts.Scaling openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.MinAxisValue>()?.Val, value, diffs, objName, "MinAxisValue");
  }
  
  private static void SetMinAxisValue(DXDrawCharts.Scaling openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.MinAxisValue,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.Scaling openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.Scaling openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.Scaling openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.Scaling? CreateModelElement(DXDrawCharts.Scaling? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawCharts.Scaling? openXmlElement, DMDrawsCharts.Scaling? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLogBase(openXmlElement, value.LogBase, diffs, objName))
        ok = false;
      if (!CmpOrientation(openXmlElement, value.Orientation, diffs, objName))
        ok = false;
      if (!CmpMaxAxisValue(openXmlElement, value.MaxAxisValue, diffs, objName))
        ok = false;
      if (!CmpMinAxisValue(openXmlElement, value.MinAxisValue, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Scaling value)
    where OpenXmlElementType: DXDrawCharts.Scaling, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.Scaling openXmlElement, DMDrawsCharts.Scaling value)
  {
    SetLogBase(openXmlElement, value?.LogBase);
    SetOrientation(openXmlElement, value?.Orientation);
    SetMaxAxisValue(openXmlElement, value?.MaxAxisValue);
    SetMinAxisValue(openXmlElement, value?.MinAxisValue);
    SetExtensionList(openXmlElement, value?.ExtensionList);
    }
  }
