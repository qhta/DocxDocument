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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.BeginChar>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SeparatorChar>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.EndChar>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.GrowOperators>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.Shape>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMMath.ShapeDelimiterKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
