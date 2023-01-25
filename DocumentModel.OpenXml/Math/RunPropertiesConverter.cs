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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.Literal>()?.Val?.Value);
  }
  
  private static bool CmpLiteral(DXMath.RunProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.Literal>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.NormalText>()?.Val?.Value);
  }
  
  private static bool CmpNormalText(DXMath.RunProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.NormalText>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ScriptValues, DMMath.ScriptKind>(openXmlElement.GetFirstChild<DXMath.Script>()?.Val?.Value);
  }
  
  private static bool CmpScript(DXMath.RunProperties openXmlElement, DMMath.ScriptKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.ScriptValues, DMMath.ScriptKind>(openXmlElement.GetFirstChild<DXMath.Script>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.StyleValues, DMMath.StyleKind>(openXmlElement.GetFirstChild<DXMath.Style>()?.Val?.Value);
  }
  
  private static bool CmpStyle(DXMath.RunProperties openXmlElement, DMMath.StyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.StyleValues, DMMath.StyleKind>(openXmlElement.GetFirstChild<DXMath.Style>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXMath.BreakConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Break>());
  }
  
  private static bool CmpBreak(DXMath.RunProperties openXmlElement, DMMath.Break? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BreakConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Break>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.Alignment>()?.Val?.Value);
  }
  
  private static bool CmpAlignment(DXMath.RunProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.Alignment>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXMath.RunProperties? openXmlElement, DMMath.RunProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLiteral(openXmlElement, value.Literal, diffs, objName))
        ok = false;
      if (!CmpNormalText(openXmlElement, value.NormalText, diffs, objName))
        ok = false;
      if (!CmpScript(openXmlElement, value.Script, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      if (!CmpBreak(openXmlElement, value.Break, diffs, objName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
