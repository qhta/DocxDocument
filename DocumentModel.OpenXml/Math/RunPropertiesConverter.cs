namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Run Properties.
/// </summary>
public static class RunPropertiesConverter
{
  /// <summary>
  /// Literal.
  /// </summary>
  private static DMMath.BooleanKind? GetLiteral(DXMath.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Literal>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLiteral(DXMath.RunProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Literal>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.Literal, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.BooleanKind? GetNormalText(DXMath.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.NormalText>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNormalText(DXMath.RunProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.NormalText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.NormalText, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.ScriptKind? GetScript(DXMath.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Script>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ScriptValues, DMMath.ScriptKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetScript(DXMath.RunProperties openXmlElement, DMMath.ScriptKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Script>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.Script, DocumentFormat.OpenXml.Math.ScriptValues, DMMath.ScriptKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.StyleKind? GetStyle(DXMath.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Style>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.StyleValues, DMMath.StyleKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetStyle(DXMath.RunProperties openXmlElement, DMMath.StyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.Style, DocumentFormat.OpenXml.Math.StyleValues, DMMath.StyleKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Break? GetBreak(DXMath.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Break>();
    if (itemElement != null)
      return DMXMath.BreakConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBreak(DXMath.RunProperties openXmlElement, DMMath.Break? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Break>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BreakConverter.CreateOpenXmlElement<DXMath.Break>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.BooleanKind? GetAlignment(DXMath.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Alignment>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAlignment(DXMath.RunProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Alignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.Alignment, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.RunProperties? CreateModelElement(DXMath.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.RunProperties();
      value.Literal = GetLiteral(openXmlElement);
      value.NormalText = GetNormalText(openXmlElement);
      value.Script = GetScript(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.Break = GetBreak(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.RunProperties? value)
    where OpenXmlElementType: DXMath.RunProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLiteral(openXmlElement, value?.Literal);
      SetNormalText(openXmlElement, value?.NormalText);
      SetScript(openXmlElement, value?.Script);
      SetStyle(openXmlElement, value?.Style);
      SetBreak(openXmlElement, value?.Break);
      SetAlignment(openXmlElement, value?.Alignment);
      return openXmlElement;
    }
    return default;
  }
}
