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
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.LayoutTarget, DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDrawsCharts.LayoutTargetKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
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
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.LeftMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
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
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.TopMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
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
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.WidthMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
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
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.HeightMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDrawsCharts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left.
  /// </summary>
  private static Double? GetLeft(DXDrawCharts.ManualLayout openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Left>()?.Val?.Value;
  }
  
  private static bool CmpLeft(DXDrawCharts.ManualLayout openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Left>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Left", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLeft(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Left>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Left{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Top.
  /// </summary>
  private static Double? GetTop(DXDrawCharts.ManualLayout openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Top>()?.Val?.Value;
  }
  
  private static bool CmpTop(DXDrawCharts.ManualLayout openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Top>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Top", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTop(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Top>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Top{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Width.
  /// </summary>
  private static Double? GetWidth(DXDrawCharts.ManualLayout openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Width>()?.Val?.Value;
  }
  
  private static bool CmpWidth(DXDrawCharts.ManualLayout openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Width>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Width", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Width>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Width{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Height.
  /// </summary>
  private static Double? GetHeight(DXDrawCharts.ManualLayout openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Height>()?.Val?.Value;
  }
  
  private static bool CmpHeight(DXDrawCharts.ManualLayout openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Height>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Height", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHeight(DXDrawCharts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Height>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Height{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.ManualLayout openXmlElement)
  {
    return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>());
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
  
  public static DMDrawsCharts.ManualLayout? CreateModelElement(DXDrawCharts.ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ManualLayout();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ManualLayout? value)
    where OpenXmlElementType: DXDrawCharts.ManualLayout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
