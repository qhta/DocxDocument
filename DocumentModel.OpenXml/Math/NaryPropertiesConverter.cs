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
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.AccentChar>()?.Val);
  }
  
  private static bool CmpAccentChar(DXMath.NaryProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.AccentChar>()?.Val, value, diffs, objName, "AccentChar");
  }
  
  private static void SetAccentChar(DXMath.NaryProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXMath.AccentChar>(openXmlElement, value);
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(openXmlElement.GetFirstChild<DXMath.LimitLocation>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetLimitLocation(DXMath.NaryProperties openXmlElement, DMMath.LimitLocationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitLocation>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(itemElement, (DMMath.LimitLocationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.LimitLocation, DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>((DMMath.LimitLocationKind)value));
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.GrowOperators>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetGrowOperators(DXMath.NaryProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.GrowOperators>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.GrowOperators, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.HideSubArgument>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHideSubArgument(DXMath.NaryProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideSubArgument>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.HideSubArgument, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.HideSuperArgument>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHideSuperArgument(DXMath.NaryProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideSuperArgument>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.HideSuperArgument, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.NaryProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (element != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXMath.NaryProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName);
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.NaryProperties value)
    where OpenXmlElementType: DXMath.NaryProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.NaryProperties openXmlElement, DMMath.NaryProperties value)
  {
    SetAccentChar(openXmlElement, value?.AccentChar);
    SetLimitLocation(openXmlElement, value?.LimitLocation);
    SetGrowOperators(openXmlElement, value?.GrowOperators);
    SetHideSubArgument(openXmlElement, value?.HideSubArgument);
    SetHideSuperArgument(openXmlElement, value?.HideSuperArgument);
    SetControlProperties(openXmlElement, value?.ControlProperties);
  }
}
