using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using SpacingBetweenLines = DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SpacingBetweenLines Class.
/// </summary>
public static class SpacingBetweenLinesConverter
{
  /// <summary>
  ///   Spacing Above Paragraph
  /// </summary>
  public static String? GetBefore(SpacingBetweenLines? openXmlElement)
  {
    return openXmlElement?.Before?.Value;
  }

  public static void SetBefore(SpacingBetweenLines? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Before = new StringValue { Value = value };
      else
        openXmlElement.Before = null;
  }

  /// <summary>
  ///   Spacing Above Paragraph IN Line Units
  /// </summary>
  public static Int32? GetBeforeLines(SpacingBetweenLines? openXmlElement)
  {
    return openXmlElement?.BeforeLines?.Value;
  }

  public static void SetBeforeLines(SpacingBetweenLines? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.BeforeLines = value;
  }

  /// <summary>
  ///   Automatically Determine Spacing Above Paragraph
  /// </summary>
  public static Boolean? GetBeforeAutoSpacing(SpacingBetweenLines? openXmlElement)
  {
    return openXmlElement?.BeforeAutoSpacing?.Value;
  }

  public static void SetBeforeAutoSpacing(SpacingBetweenLines? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BeforeAutoSpacing = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.BeforeAutoSpacing = null;
  }

  /// <summary>
  ///   Spacing Below Paragraph
  /// </summary>
  public static String? GetAfter(SpacingBetweenLines? openXmlElement)
  {
    return openXmlElement?.After?.Value;
  }

  public static void SetAfter(SpacingBetweenLines? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.After = new StringValue { Value = value };
      else
        openXmlElement.After = null;
  }

  /// <summary>
  ///   Spacing Below Paragraph in Line Units
  /// </summary>
  public static Int32? GetAfterLines(SpacingBetweenLines? openXmlElement)
  {
    return openXmlElement?.AfterLines?.Value;
  }

  public static void SetAfterLines(SpacingBetweenLines? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.AfterLines = value;
  }

  /// <summary>
  ///   Automatically Determine Spacing Below Paragraph
  /// </summary>
  public static Boolean? GetAfterAutoSpacing(SpacingBetweenLines? openXmlElement)
  {
    return openXmlElement?.AfterAutoSpacing?.Value;
  }

  public static void SetAfterAutoSpacing(SpacingBetweenLines? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AfterAutoSpacing = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.AfterAutoSpacing = null;
  }

  /// <summary>
  ///   Spacing Between Lines in Paragraph
  /// </summary>
  public static String? GetLine(SpacingBetweenLines? openXmlElement)
  {
    return openXmlElement?.Line?.Value;
  }

  public static void SetLine(SpacingBetweenLines? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Line = new StringValue { Value = value };
      else
        openXmlElement.Line = null;
  }

  /// <summary>
  ///   Type of Spacing Between Lines
  /// </summary>
  public static LineSpacingRuleKind? GetLineRule(SpacingBetweenLines? openXmlElement)
  {
    return EnumValueConverter.GetValue<LineSpacingRuleValues, LineSpacingRuleKind>(openXmlElement?.LineRule?.Value);
  }

  public static void SetLineRule(SpacingBetweenLines? openXmlElement, LineSpacingRuleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LineRule = EnumValueConverter.CreateEnumValue<LineSpacingRuleValues, LineSpacingRuleKind>(value);
  }

  public static DocumentModel.Wordprocessing.SpacingBetweenLines? CreateModelElement(SpacingBetweenLines? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SpacingBetweenLines? value)
    where OpenXmlElementType : SpacingBetweenLines, new()
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