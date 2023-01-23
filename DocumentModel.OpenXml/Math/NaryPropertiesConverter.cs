namespace DocumentModel.OpenXml.Math;

/// <summary>
/// n-ary Properties.
/// </summary>
public static class NaryPropertiesConverter
{
  /// <summary>
  /// n-ary Operator Character.
  /// </summary>
  private static String? GetAccentChar(DXMath.NaryProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXMath.AccentChar>()?.Val?.Value;
  }
  
  private static bool CmpAccentChar(DXMath.NaryProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXMath.AccentChar>()?.Val?.Value == value;
  }
  
  private static void SetAccentChar(DXMath.NaryProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.AccentChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.AccentChar { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// n-ary Limit Location.
  /// </summary>
  private static DMMath.LimitLocationKind? GetLimitLocation(DXMath.NaryProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(openXmlElement.GetFirstChild<DXMath.LimitLocation>()?.Val?.Value);
  }
  
  private static bool CmpLimitLocation(DXMath.NaryProperties openXmlElement, DMMath.LimitLocationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(openXmlElement.GetFirstChild<DXMath.LimitLocation>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimitLocation(DXMath.NaryProperties openXmlElement, DMMath.LimitLocationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitLocation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.LimitLocation, DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// n-ary Grow.
  /// </summary>
  private static DMMath.BooleanKind? GetGrowOperators(DXMath.NaryProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.GrowOperators>()?.Val?.Value);
  }
  
  private static bool CmpGrowOperators(DXMath.NaryProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.GrowOperators>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGrowOperators(DXMath.NaryProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.GrowOperators>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.GrowOperators, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Subscript (n-ary).
  /// </summary>
  private static DMMath.BooleanKind? GetHideSubArgument(DXMath.NaryProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.HideSubArgument>()?.Val?.Value);
  }
  
  private static bool CmpHideSubArgument(DXMath.NaryProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.HideSubArgument>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHideSubArgument(DXMath.NaryProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideSubArgument>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.HideSubArgument, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Superscript (n-ary).
  /// </summary>
  private static DMMath.BooleanKind? GetHideSuperArgument(DXMath.NaryProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.HideSuperArgument>()?.Val?.Value);
  }
  
  private static bool CmpHideSuperArgument(DXMath.NaryProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.HideSuperArgument>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHideSuperArgument(DXMath.NaryProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideSuperArgument>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.HideSuperArgument, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.NaryProperties openXmlElement)
  {
    return DMXMath.ControlPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.ControlProperties>());
  }
  
  private static bool CmpControlProperties(DXMath.NaryProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetControlProperties(DXMath.NaryProperties openXmlElement, DMMath.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ControlPropertiesConverter.CreateOpenXmlElement<DXMath.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.NaryProperties? CreateModelElement(DXMath.NaryProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.NaryProperties();
      value.AccentChar = GetAccentChar(openXmlElement);
      value.LimitLocation = GetLimitLocation(openXmlElement);
      value.GrowOperators = GetGrowOperators(openXmlElement);
      value.HideSubArgument = GetHideSubArgument(openXmlElement);
      value.HideSuperArgument = GetHideSuperArgument(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.NaryProperties? openXmlElement, DMMath.NaryProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAccentChar(openXmlElement, value.AccentChar, diffs, objName))
        ok = false;
      if (!CmpLimitLocation(openXmlElement, value.LimitLocation, diffs, objName))
        ok = false;
      if (!CmpGrowOperators(openXmlElement, value.GrowOperators, diffs, objName))
        ok = false;
      if (!CmpHideSubArgument(openXmlElement, value.HideSubArgument, diffs, objName))
        ok = false;
      if (!CmpHideSuperArgument(openXmlElement, value.HideSuperArgument, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.NaryProperties? value)
    where OpenXmlElementType: DXMath.NaryProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAccentChar(openXmlElement, value?.AccentChar);
      SetLimitLocation(openXmlElement, value?.LimitLocation);
      SetGrowOperators(openXmlElement, value?.GrowOperators);
      SetHideSubArgument(openXmlElement, value?.HideSubArgument);
      SetHideSuperArgument(openXmlElement, value?.HideSuperArgument);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
