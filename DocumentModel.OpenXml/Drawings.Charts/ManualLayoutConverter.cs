namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Manual Layout.
/// </summary>
public static class ManualLayoutConverter
{
  /// <summary>
  /// Layout Target.
  /// </summary>
  private static DMDrawsCharts.LayoutTargetKind? GetLayoutTarget(DXDrawCharts.ManualLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDrawsCharts.LayoutTargetKind>(openXmlElement.GetFirstChild<DXDrawCharts.LayoutTarget>()?.Val?.Value);
  }
  
  private static bool CmpLayoutTarget(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutTargetKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDrawsCharts.LayoutTargetKind>(openXmlElement.GetFirstChild<DXDrawCharts.LayoutTarget>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLayoutTarget(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutTargetKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LayoutTarget>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDrawsCharts.LayoutTargetKind>(itemElement, (DMDrawsCharts.LayoutTargetKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.LayoutTarget, DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDrawsCharts.LayoutTargetKind>((DMDrawsCharts.LayoutTargetKind)value));
  }
  
  /// <summary>
  /// Left Mode.
  /// </summary>
  private static DMDrawsCharts.LayoutMode? GetLeftMode(DXDrawCharts.ManualLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(openXmlElement.GetFirstChild<DXDrawCharts.LeftMode>()?.Val?.Value);
  }
  
  private static bool CmpLeftMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(openXmlElement.GetFirstChild<DXDrawCharts.LeftMode>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLeftMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LeftMode>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(itemElement, (DMDrawsCharts.LayoutMode)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.LeftMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>((DMDrawsCharts.LayoutMode)value));
  }
  
  /// <summary>
  /// Top Mode.
  /// </summary>
  private static DMDrawsCharts.LayoutMode? GetTopMode(DXDrawCharts.ManualLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(openXmlElement.GetFirstChild<DXDrawCharts.TopMode>()?.Val?.Value);
  }
  
  private static bool CmpTopMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(openXmlElement.GetFirstChild<DXDrawCharts.TopMode>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTopMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TopMode>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(itemElement, (DMDrawsCharts.LayoutMode)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.TopMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>((DMDrawsCharts.LayoutMode)value));
  }
  
  /// <summary>
  /// Width Mode.
  /// </summary>
  private static DMDrawsCharts.LayoutMode? GetWidthMode(DXDrawCharts.ManualLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(openXmlElement.GetFirstChild<DXDrawCharts.WidthMode>()?.Val?.Value);
  }
  
  private static bool CmpWidthMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(openXmlElement.GetFirstChild<DXDrawCharts.WidthMode>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWidthMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.WidthMode>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(itemElement, (DMDrawsCharts.LayoutMode)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.WidthMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>((DMDrawsCharts.LayoutMode)value));
  }
  
  /// <summary>
  /// Height Mode.
  /// </summary>
  private static DMDrawsCharts.LayoutMode? GetHeightMode(DXDrawCharts.ManualLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(openXmlElement.GetFirstChild<DXDrawCharts.HeightMode>()?.Val?.Value);
  }
  
  private static bool CmpHeightMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(openXmlElement.GetFirstChild<DXDrawCharts.HeightMode>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHeightMode(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.HeightMode>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(itemElement, (DMDrawsCharts.LayoutMode)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.HeightMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>((DMDrawsCharts.LayoutMode)value));
  }
  
  /// <summary>
  /// Left.
  /// </summary>
  private static Double? GetLeft(DXDrawCharts.ManualLayout openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Left>()?.Val);
  }
  
  private static bool CmpLeft(DXDrawCharts.ManualLayout openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Left>()?.Val, value, diffs, objName, "Left");
  }
  
  private static void SetLeft(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Left,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Top.
  /// </summary>
  private static Double? GetTop(DXDrawCharts.ManualLayout openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Top>()?.Val);
  }
  
  private static bool CmpTop(DXDrawCharts.ManualLayout openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Top>()?.Val, value, diffs, objName, "Top");
  }
  
  private static void SetTop(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Top,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Width.
  /// </summary>
  private static Double? GetWidth(DXDrawCharts.ManualLayout openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Width>()?.Val);
  }
  
  private static bool CmpWidth(DXDrawCharts.ManualLayout openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Width>()?.Val, value, diffs, objName, "Width");
  }
  
  private static void SetWidth(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Width,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Height.
  /// </summary>
  private static Double? GetHeight(DXDrawCharts.ManualLayout openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Height>()?.Val);
  }
  
  private static bool CmpHeight(DXDrawCharts.ManualLayout openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Height>()?.Val, value, diffs, objName, "Height");
  }
  
  private static void SetHeight(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Height,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.ManualLayout openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.ManualLayout? CreateModelElement(DXDrawCharts.ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ManualLayout();
      value.LayoutTarget = GetLayoutTarget(openXmlElement);
      value.LeftMode = GetLeftMode(openXmlElement);
      value.TopMode = GetTopMode(openXmlElement);
      value.WidthMode = GetWidthMode(openXmlElement);
      value.HeightMode = GetHeightMode(openXmlElement);
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ManualLayout? openXmlElement, DMDrawsCharts.ManualLayout? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLayoutTarget(openXmlElement, value.LayoutTarget, diffs, objName))
        ok = false;
      if (!CmpLeftMode(openXmlElement, value.LeftMode, diffs, objName))
        ok = false;
      if (!CmpTopMode(openXmlElement, value.TopMode, diffs, objName))
        ok = false;
      if (!CmpWidthMode(openXmlElement, value.WidthMode, diffs, objName))
        ok = false;
      if (!CmpHeightMode(openXmlElement, value.HeightMode, diffs, objName))
        ok = false;
      if (!CmpLeft(openXmlElement, value.Left, diffs, objName))
        ok = false;
      if (!CmpTop(openXmlElement, value.Top, diffs, objName))
        ok = false;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ManualLayout value)
    where OpenXmlElementType: DXDrawCharts.ManualLayout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ManualLayout openXmlElement, DMDrawsCharts.ManualLayout value)
  {
    SetLayoutTarget(openXmlElement, value?.LayoutTarget);
    SetLeftMode(openXmlElement, value?.LeftMode);
    SetTopMode(openXmlElement, value?.TopMode);
    SetWidthMode(openXmlElement, value?.WidthMode);
    SetHeightMode(openXmlElement, value?.HeightMode);
    SetLeft(openXmlElement, value?.Left);
    SetTop(openXmlElement, value?.Top);
    SetWidth(openXmlElement, value?.Width);
    SetHeight(openXmlElement, value?.Height);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
