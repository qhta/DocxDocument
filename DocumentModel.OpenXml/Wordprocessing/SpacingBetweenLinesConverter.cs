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
    return openXmlElement?.Before?.Value;
  }
  
  private static void SetBefore(DXW.SpacingBetweenLines openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Before = new StringValue { Value = value };
    else
      openXmlElement.Before = null;
  }
  
  /// <summary>
  /// Spacing Above Paragraph IN Line Units
  /// </summary>
  private static Int32? GetBeforeLines(DXW.SpacingBetweenLines openXmlElement)
  {
    return openXmlElement.BeforeLines?.Value;
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
    return openXmlElement?.BeforeAutoSpacing?.Value;
  }
  
  private static void SetBeforeAutoSpacing(DXW.SpacingBetweenLines openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BeforeAutoSpacing = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.BeforeAutoSpacing = null;
  }
  
  /// <summary>
  /// Spacing Below Paragraph
  /// </summary>
  private static String? GetAfter(DXW.SpacingBetweenLines openXmlElement)
  {
    return openXmlElement?.After?.Value;
  }
  
  private static void SetAfter(DXW.SpacingBetweenLines openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.After = new StringValue { Value = value };
    else
      openXmlElement.After = null;
  }
  
  /// <summary>
  /// Spacing Below Paragraph in Line Units
  /// </summary>
  private static Int32? GetAfterLines(DXW.SpacingBetweenLines openXmlElement)
  {
    return openXmlElement.AfterLines?.Value;
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
    return openXmlElement?.AfterAutoSpacing?.Value;
  }
  
  private static void SetAfterAutoSpacing(DXW.SpacingBetweenLines openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AfterAutoSpacing = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.AfterAutoSpacing = null;
  }
  
  /// <summary>
  /// Spacing Between Lines in Paragraph
  /// </summary>
  private static String? GetLine(DXW.SpacingBetweenLines openXmlElement)
  {
    return openXmlElement?.Line?.Value;
  }
  
  private static void SetLine(DXW.SpacingBetweenLines openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Line = new StringValue { Value = value };
    else
      openXmlElement.Line = null;
  }
  
  /// <summary>
  /// Type of Spacing Between Lines
  /// </summary>
  private static DMW.LineSpacingRuleKind? GetLineRule(DXW.SpacingBetweenLines openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues, DMW.LineSpacingRuleKind>(openXmlElement?.LineRule?.Value);
  }
  
  private static void SetLineRule(DXW.SpacingBetweenLines openXmlElement, DMW.LineSpacingRuleKind? value)
  {
    openXmlElement.LineRule = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues, DMW.LineSpacingRuleKind>(value);
  }
  
  public static DMW.SpacingBetweenLines? CreateModelElement(DXW.SpacingBetweenLines? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SpacingBetweenLines();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SpacingBetweenLines? value)
    where OpenXmlElementType: DXW.SpacingBetweenLines, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBefore(openXmlElement, value?.Before);
      SetBeforeLines(openXmlElement, value?.BeforeLines);
      SetBeforeAutoSpacing(openXmlElement, value?.BeforeAutoSpacing);
      SetAfter(openXmlElement, value?.After);
      SetAfterLines(openXmlElement, value?.AfterLines);
      SetAfterAutoSpacing(openXmlElement, value?.AfterAutoSpacing);
      SetLine(openXmlElement, value?.Line);
      SetLineRule(openXmlElement, value?.LineRule);
      return openXmlElement;
    }
    return default;
  }
}
