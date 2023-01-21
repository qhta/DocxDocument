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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.AccentChar>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitLocation>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMMath.LimitLocationKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.GrowOperators>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideSubArgument>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideSuperArgument>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
