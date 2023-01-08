namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SpacingBetweenLines Class.
/// </summary>
public static class SpacingBetweenLinesConverter
{
  /// <summary>
  /// Spacing Above Paragraph
  /// </summary>
  public static String? GetBefore(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetBefore(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Spacing Above Paragraph IN Line Units
  /// </summary>
  public static Int32? GetBeforeLines(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBeforeLines(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Automatically Determine Spacing Above Paragraph
  /// </summary>
  public static Boolean? GetBeforeAutoSpacing(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBeforeAutoSpacing(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Spacing Below Paragraph
  /// </summary>
  public static String? GetAfter(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAfter(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Spacing Below Paragraph in Line Units
  /// </summary>
  public static Int32? GetAfterLines(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAfterLines(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Automatically Determine Spacing Below Paragraph
  /// </summary>
  public static Boolean? GetAfterAutoSpacing(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAfterAutoSpacing(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Spacing Between Lines in Paragraph
  /// </summary>
  public static String? GetLine(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLine(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Type of Spacing Between Lines
  /// </summary>
  public static DocumentModel.Wordprocessing.LineSpacingRuleKind? GetLineRule(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues, DocumentModel.Wordprocessing.LineSpacingRuleKind>(openXmlElement?.LineRule?.Value);
  }
  
  public static void SetLineRule(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? openXmlElement, DocumentModel.Wordprocessing.LineSpacingRuleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LineRule = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues, DocumentModel.Wordprocessing.LineSpacingRuleKind>(value);
  }
  
}
