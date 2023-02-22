namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SpacingBetweenLines Class.
/// </summary>
public static class SpacingBetweenLinesConverter
{
  /// <summary>
  /// Spacing Above Paragraph
  /// </summary>
  private static String? GetBefore(DXW.SpacingBetweenLines openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Before);
  }
  
  private static bool CmpBefore(DXW.SpacingBetweenLines openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Before, value, diffs, objName, "Before");
  }
  
  private static void SetBefore(DXW.SpacingBetweenLines openXmlElement, String? value)
  {
    openXmlElement.Before = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Spacing Above Paragraph IN Line Units
  /// </summary>
  private static Int32? GetBeforeLines(DXW.SpacingBetweenLines openXmlElement)
  {
    return openXmlElement?.BeforeLines?.Value;
  }
  
  private static bool CmpBeforeLines(DXW.SpacingBetweenLines openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BeforeLines?.Value == value) return true;
    diffs?.Add(objName, "BeforeLines", openXmlElement?.BeforeLines?.Value, value);
    return false;
  }
  
  private static void SetBeforeLines(DXW.SpacingBetweenLines openXmlElement, Int32? value)
  {
    openXmlElement.BeforeLines = value;
  }
  
  /// <summary>
  /// Automatically Determine Spacing Above Paragraph
  /// </summary>
  private static Boolean? GetBeforeAutoSpacing(DXW.SpacingBetweenLines openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.BeforeAutoSpacing);
  }
  
  private static bool CmpBeforeAutoSpacing(DXW.SpacingBetweenLines openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.BeforeAutoSpacing, value, diffs, objName, "BeforeAutoSpacing");
  }
  
  private static void SetBeforeAutoSpacing(DXW.SpacingBetweenLines openXmlElement, Boolean? value)
  {
    openXmlElement.BeforeAutoSpacing = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Spacing Below Paragraph
  /// </summary>
  private static String? GetAfter(DXW.SpacingBetweenLines openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.After);
  }
  
  private static bool CmpAfter(DXW.SpacingBetweenLines openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.After, value, diffs, objName, "After");
  }
  
  private static void SetAfter(DXW.SpacingBetweenLines openXmlElement, String? value)
  {
    openXmlElement.After = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Spacing Below Paragraph in Line Units
  /// </summary>
  private static Int32? GetAfterLines(DXW.SpacingBetweenLines openXmlElement)
  {
    return openXmlElement?.AfterLines?.Value;
  }
  
  private static bool CmpAfterLines(DXW.SpacingBetweenLines openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AfterLines?.Value == value) return true;
    diffs?.Add(objName, "AfterLines", openXmlElement?.AfterLines?.Value, value);
    return false;
  }
  
  private static void SetAfterLines(DXW.SpacingBetweenLines openXmlElement, Int32? value)
  {
    openXmlElement.AfterLines = value;
  }
  
  /// <summary>
  /// Automatically Determine Spacing Below Paragraph
  /// </summary>
  private static Boolean? GetAfterAutoSpacing(DXW.SpacingBetweenLines openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.AfterAutoSpacing);
  }
  
  private static bool CmpAfterAutoSpacing(DXW.SpacingBetweenLines openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.AfterAutoSpacing, value, diffs, objName, "AfterAutoSpacing");
  }
  
  private static void SetAfterAutoSpacing(DXW.SpacingBetweenLines openXmlElement, Boolean? value)
  {
    openXmlElement.AfterAutoSpacing = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Spacing Between Lines in Paragraph
  /// </summary>
  private static String? GetLine(DXW.SpacingBetweenLines openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Line);
  }
  
  private static bool CmpLine(DXW.SpacingBetweenLines openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Line, value, diffs, objName, "Line");
  }
  
  private static void SetLine(DXW.SpacingBetweenLines openXmlElement, String? value)
  {
    openXmlElement.Line = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Type of Spacing Between Lines
  /// </summary>
  private static DMW.LineSpacingRuleKind? GetLineRule(DXW.SpacingBetweenLines openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues, DMW.LineSpacingRuleKind>(openXmlElement?.LineRule?.Value);
  }
  
  private static bool CmpLineRule(DXW.SpacingBetweenLines openXmlElement, DMW.LineSpacingRuleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues, DMW.LineSpacingRuleKind>(openXmlElement?.LineRule?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineRule(DXW.SpacingBetweenLines openXmlElement, DMW.LineSpacingRuleKind? value)
  {
    openXmlElement.LineRule = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues, DMW.LineSpacingRuleKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.SpacingBetweenLines? CreateModelElement(DXW.SpacingBetweenLines? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SpacingBetweenLines();
      value.Before = GetBefore(openXmlElement);
      value.BeforeLines = GetBeforeLines(openXmlElement);
      value.BeforeAutoSpacing = GetBeforeAutoSpacing(openXmlElement);
      value.After = GetAfter(openXmlElement);
      value.AfterLines = GetAfterLines(openXmlElement);
      value.AfterAutoSpacing = GetAfterAutoSpacing(openXmlElement);
      value.Line = GetLine(openXmlElement);
      value.LineRule = GetLineRule(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SpacingBetweenLines? openXmlElement, DMW.SpacingBetweenLines? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBefore(openXmlElement, value.Before, diffs, objName))
        ok = false;
      if (!CmpBeforeLines(openXmlElement, value.BeforeLines, diffs, objName))
        ok = false;
      if (!CmpBeforeAutoSpacing(openXmlElement, value.BeforeAutoSpacing, diffs, objName))
        ok = false;
      if (!CmpAfter(openXmlElement, value.After, diffs, objName))
        ok = false;
      if (!CmpAfterLines(openXmlElement, value.AfterLines, diffs, objName))
        ok = false;
      if (!CmpAfterAutoSpacing(openXmlElement, value.AfterAutoSpacing, diffs, objName))
        ok = false;
      if (!CmpLine(openXmlElement, value.Line, diffs, objName))
        ok = false;
      if (!CmpLineRule(openXmlElement, value.LineRule, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SpacingBetweenLines value)
    where OpenXmlElementType: DXW.SpacingBetweenLines, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SpacingBetweenLines openXmlElement, DMW.SpacingBetweenLines value)
  {
    SetBefore(openXmlElement, value?.Before);
    SetBeforeLines(openXmlElement, value?.BeforeLines);
    SetBeforeAutoSpacing(openXmlElement, value?.BeforeAutoSpacing);
    SetAfter(openXmlElement, value?.After);
    SetAfterLines(openXmlElement, value?.AfterLines);
    SetAfterAutoSpacing(openXmlElement, value?.AfterAutoSpacing);
    SetLine(openXmlElement, value?.Line);
    SetLineRule(openXmlElement, value?.LineRule);
    }
  }
