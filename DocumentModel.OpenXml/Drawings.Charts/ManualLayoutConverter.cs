namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Manual Layout.
/// </summary>
public static class ManualLayoutConverter
{
  /// <summary>
  /// Layout Target.
  /// </summary>
  private static DMDC.LayoutTargetKind? GetLayoutTarget(DXDC.ManualLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDC.LayoutTargetKind>(openXmlElement.GetFirstChild<DXDC.LayoutTarget>()?.Val?.Value);
  }
  
  private static bool CmpLayoutTarget(DXDC.ManualLayout openXmlElement, DMDC.LayoutTargetKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDC.LayoutTargetKind>(openXmlElement.GetFirstChild<DXDC.LayoutTarget>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetLayoutTarget(DXDC.ManualLayout openXmlElement, DMDC.LayoutTargetKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.LayoutTarget>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDC.LayoutTargetKind>(itemElement, (DMDC.LayoutTargetKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.LayoutTarget, DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDC.LayoutTargetKind>((DMDC.LayoutTargetKind)value));
  }
  
  /// <summary>
  /// Left Mode.
  /// </summary>
  private static DMDC.LayoutMode? GetLeftMode(DXDC.ManualLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(openXmlElement.GetFirstChild<DXDC.LeftMode>()?.Val?.Value);
  }
  
  private static bool CmpLeftMode(DXDC.ManualLayout openXmlElement, DMDC.LayoutMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(openXmlElement.GetFirstChild<DXDC.LeftMode>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetLeftMode(DXDC.ManualLayout openXmlElement, DMDC.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.LeftMode>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(itemElement, (DMDC.LayoutMode)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.LeftMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>((DMDC.LayoutMode)value));
  }
  
  /// <summary>
  /// Top Mode.
  /// </summary>
  private static DMDC.LayoutMode? GetTopMode(DXDC.ManualLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(openXmlElement.GetFirstChild<DXDC.TopMode>()?.Val?.Value);
  }
  
  private static bool CmpTopMode(DXDC.ManualLayout openXmlElement, DMDC.LayoutMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(openXmlElement.GetFirstChild<DXDC.TopMode>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetTopMode(DXDC.ManualLayout openXmlElement, DMDC.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TopMode>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(itemElement, (DMDC.LayoutMode)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.TopMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>((DMDC.LayoutMode)value));
  }
  
  /// <summary>
  /// Width Mode.
  /// </summary>
  private static DMDC.LayoutMode? GetWidthMode(DXDC.ManualLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(openXmlElement.GetFirstChild<DXDC.WidthMode>()?.Val?.Value);
  }
  
  private static bool CmpWidthMode(DXDC.ManualLayout openXmlElement, DMDC.LayoutMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(openXmlElement.GetFirstChild<DXDC.WidthMode>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetWidthMode(DXDC.ManualLayout openXmlElement, DMDC.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.WidthMode>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(itemElement, (DMDC.LayoutMode)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.WidthMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>((DMDC.LayoutMode)value));
  }
  
  /// <summary>
  /// Height Mode.
  /// </summary>
  private static DMDC.LayoutMode? GetHeightMode(DXDC.ManualLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(openXmlElement.GetFirstChild<DXDC.HeightMode>()?.Val?.Value);
  }
  
  private static bool CmpHeightMode(DXDC.ManualLayout openXmlElement, DMDC.LayoutMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(openXmlElement.GetFirstChild<DXDC.HeightMode>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetHeightMode(DXDC.ManualLayout openXmlElement, DMDC.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.HeightMode>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>(itemElement, (DMDC.LayoutMode)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.HeightMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DMDC.LayoutMode>((DMDC.LayoutMode)value));
  }
  
  /// <summary>
  /// Left.
  /// </summary>
  private static Double? GetLeft(DXDC.ManualLayout openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Left>()?.Val);
  }
  
  private static bool CmpLeft(DXDC.ManualLayout openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Left>()?.Val, value, diffs, objName, "Left");
  }
  
  private static void SetLeft(DXDC.ManualLayout openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.Left,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Top.
  /// </summary>
  private static Double? GetTop(DXDC.ManualLayout openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Top>()?.Val);
  }
  
  private static bool CmpTop(DXDC.ManualLayout openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Top>()?.Val, value, diffs, objName, "Top");
  }
  
  private static void SetTop(DXDC.ManualLayout openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.Top,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Width.
  /// </summary>
  private static Double? GetWidth(DXDC.ManualLayout openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Width>()?.Val);
  }
  
  private static bool CmpWidth(DXDC.ManualLayout openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Width>()?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetWidth(DXDC.ManualLayout openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.Width,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Height.
  /// </summary>
  private static Double? GetHeight(DXDC.ManualLayout openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Height>()?.Val);
  }
  
  private static bool CmpHeight(DXDC.ManualLayout openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Height>()?.Val, value, diffs, objName, "Height");
  }
  
  private static void SetHeight(DXDC.ManualLayout openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.Height,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.ManualLayout openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.ManualLayout openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.ManualLayout openXmlElement, DMDC.ExtensionList? value)
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
  
  public static DMD.Charts.ManualLayout? CreateModelElement(DXDC.ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.ManualLayout();
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
  
  public static bool CompareModelElement(DXDC.ManualLayout? openXmlElement, DMDC.ManualLayout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLayoutTarget(openXmlElement, value.LayoutTarget, diffs, objName, propName))
        ok = false;
      if (!CmpLeftMode(openXmlElement, value.LeftMode, diffs, objName, propName))
        ok = false;
      if (!CmpTopMode(openXmlElement, value.TopMode, diffs, objName, propName))
        ok = false;
      if (!CmpWidthMode(openXmlElement, value.WidthMode, diffs, objName, propName))
        ok = false;
      if (!CmpHeightMode(openXmlElement, value.HeightMode, diffs, objName, propName))
        ok = false;
      if (!CmpLeft(openXmlElement, value.Left, diffs, objName, propName))
        ok = false;
      if (!CmpTop(openXmlElement, value.Top, diffs, objName, propName))
        ok = false;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName, propName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ManualLayout value)
    where OpenXmlElementType: DXDC.ManualLayout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ManualLayout openXmlElement, DMDC.ManualLayout value)
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
