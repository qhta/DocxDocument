namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Delimiter Properties.
/// </summary>
public static class DelimiterPropertiesConverter
{
  /// <summary>
  /// Delimiter Beginning Character.
  /// </summary>
  private static String? GetBeginChar(DXMath.DelimiterProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.BeginChar>()?.Val);
  }
  
  private static bool CmpBeginChar(DXMath.DelimiterProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.BeginChar>()?.Val, value, diffs, objName, "BeginChar");
  }
  
  private static void SetBeginChar(DXMath.DelimiterProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXMath.BeginChar>(openXmlElement, value);
  }
  
  /// <summary>
  /// Delimiter Separator Character.
  /// </summary>
  private static String? GetSeparatorChar(DXMath.DelimiterProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.SeparatorChar>()?.Val);
  }
  
  private static bool CmpSeparatorChar(DXMath.DelimiterProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.SeparatorChar>()?.Val, value, diffs, objName, "SeparatorChar");
  }
  
  private static void SetSeparatorChar(DXMath.DelimiterProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXMath.SeparatorChar>(openXmlElement, value);
  }
  
  /// <summary>
  /// Delimiter Ending Character.
  /// </summary>
  private static String? GetEndChar(DXMath.DelimiterProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.EndChar>()?.Val);
  }
  
  private static bool CmpEndChar(DXMath.DelimiterProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.EndChar>()?.Val, value, diffs, objName, "EndChar");
  }
  
  private static void SetEndChar(DXMath.DelimiterProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXMath.EndChar>(openXmlElement, value);
  }
  
  /// <summary>
  /// Delimiter Grow.
  /// </summary>
  private static DMMath.BooleanKind? GetGrowOperators(DXMath.DelimiterProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.GrowOperators>()?.Val?.Value);
  }
  
  private static bool CmpGrowOperators(DXMath.DelimiterProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.GrowOperators>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetGrowOperators(DXMath.DelimiterProperties openXmlElement, DMMath.BooleanKind? value)
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
  /// Shape (Delimiters).
  /// </summary>
  private static DMMath.ShapeDelimiterKind? GetShape(DXMath.DelimiterProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMMath.ShapeDelimiterKind>(openXmlElement.GetFirstChild<DXMath.Shape>()?.Val?.Value);
  }
  
  private static bool CmpShape(DXMath.DelimiterProperties openXmlElement, DMMath.ShapeDelimiterKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMMath.ShapeDelimiterKind>(openXmlElement.GetFirstChild<DXMath.Shape>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetShape(DXMath.DelimiterProperties openXmlElement, DMMath.ShapeDelimiterKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Shape>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMMath.ShapeDelimiterKind>(itemElement, (DMMath.ShapeDelimiterKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.Shape, DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMMath.ShapeDelimiterKind>((DMMath.ShapeDelimiterKind)value));
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.DelimiterProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (element != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXMath.DelimiterProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXMath.DelimiterProperties openXmlElement, DMMath.ControlProperties? value)
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
  
  public static DocumentModel.Math.DelimiterProperties? CreateModelElement(DXMath.DelimiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.DelimiterProperties();
      value.BeginChar = GetBeginChar(openXmlElement);
      value.SeparatorChar = GetSeparatorChar(openXmlElement);
      value.EndChar = GetEndChar(openXmlElement);
      value.GrowOperators = GetGrowOperators(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.DelimiterProperties? openXmlElement, DMMath.DelimiterProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBeginChar(openXmlElement, value.BeginChar, diffs, objName))
        ok = false;
      if (!CmpSeparatorChar(openXmlElement, value.SeparatorChar, diffs, objName))
        ok = false;
      if (!CmpEndChar(openXmlElement, value.EndChar, diffs, objName))
        ok = false;
      if (!CmpGrowOperators(openXmlElement, value.GrowOperators, diffs, objName))
        ok = false;
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.DelimiterProperties value)
    where OpenXmlElementType: DXMath.DelimiterProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.DelimiterProperties openXmlElement, DMMath.DelimiterProperties value)
  {
    SetBeginChar(openXmlElement, value?.BeginChar);
    SetSeparatorChar(openXmlElement, value?.SeparatorChar);
    SetEndChar(openXmlElement, value?.EndChar);
    SetGrowOperators(openXmlElement, value?.GrowOperators);
    SetShape(openXmlElement, value?.Shape);
    SetControlProperties(openXmlElement, value?.ControlProperties);
  }
}
