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
      return openXmlElement?.GetFirstChild<DXMath.BeginChar>()?.Val?.Value;
  }
  
  private static bool CmpBeginChar(DXMath.DelimiterProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXMath.BeginChar>()?.Val?.Value == value;
  }
  
  private static void SetBeginChar(DXMath.DelimiterProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BeginChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.BeginChar { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Delimiter Separator Character.
  /// </summary>
  private static String? GetSeparatorChar(DXMath.DelimiterProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXMath.SeparatorChar>()?.Val?.Value;
  }
  
  private static bool CmpSeparatorChar(DXMath.DelimiterProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXMath.SeparatorChar>()?.Val?.Value == value;
  }
  
  private static void SetSeparatorChar(DXMath.DelimiterProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SeparatorChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.SeparatorChar { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Delimiter Ending Character.
  /// </summary>
  private static String? GetEndChar(DXMath.DelimiterProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXMath.EndChar>()?.Val?.Value;
  }
  
  private static bool CmpEndChar(DXMath.DelimiterProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXMath.EndChar>()?.Val?.Value == value;
  }
  
  private static void SetEndChar(DXMath.DelimiterProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.EndChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.EndChar { Val = value };
      openXmlElement.AddChild(itemElement);
    }
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.GrowOperators>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGrowOperators(DXMath.DelimiterProperties openXmlElement, DMMath.BooleanKind? value)
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
  /// Shape (Delimiters).
  /// </summary>
  private static DMMath.ShapeDelimiterKind? GetShape(DXMath.DelimiterProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMMath.ShapeDelimiterKind>(openXmlElement.GetFirstChild<DXMath.Shape>()?.Val?.Value);
  }
  
  private static bool CmpShape(DXMath.DelimiterProperties openXmlElement, DMMath.ShapeDelimiterKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMMath.ShapeDelimiterKind>(openXmlElement.GetFirstChild<DXMath.Shape>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape(DXMath.DelimiterProperties openXmlElement, DMMath.ShapeDelimiterKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.Shape, DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMMath.ShapeDelimiterKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.DelimiterProperties openXmlElement)
  {
    return DMXMath.ControlPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.ControlProperties>());
  }
  
  private static bool CmpControlProperties(DXMath.DelimiterProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMMath.DelimiterProperties? CreateModelElement(DXMath.DelimiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.DelimiterProperties();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.DelimiterProperties? value)
    where OpenXmlElementType: DXMath.DelimiterProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBeginChar(openXmlElement, value?.BeginChar);
      SetSeparatorChar(openXmlElement, value?.SeparatorChar);
      SetEndChar(openXmlElement, value?.EndChar);
      SetGrowOperators(openXmlElement, value?.GrowOperators);
      SetShape(openXmlElement, value?.Shape);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
