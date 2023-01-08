namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LineNumberType Class.
/// </summary>
public static class LineNumberTypeConverter
{
  /// <summary>
  /// Line Number Increments to Display
  /// </summary>
  public static Int16? GetCountBy(DocumentFormat.OpenXml.Wordprocessing.LineNumberType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCountBy(DocumentFormat.OpenXml.Wordprocessing.LineNumberType? openXmlElement, Int16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Line Numbering Starting Value
  /// </summary>
  public static Int16? GetStart(DocumentFormat.OpenXml.Wordprocessing.LineNumberType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStart(DocumentFormat.OpenXml.Wordprocessing.LineNumberType? openXmlElement, Int16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Distance Between Text and Line Numbering
  /// </summary>
  public static String? GetDistance(DocumentFormat.OpenXml.Wordprocessing.LineNumberType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetDistance(DocumentFormat.OpenXml.Wordprocessing.LineNumberType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Line Numbering Restart Setting
  /// </summary>
  public static DocumentModel.Wordprocessing.LineNumberRestartKind? GetRestart(DocumentFormat.OpenXml.Wordprocessing.LineNumberType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues, DocumentModel.Wordprocessing.LineNumberRestartKind>(openXmlElement?.Restart?.Value);
  }
  
  public static void SetRestart(DocumentFormat.OpenXml.Wordprocessing.LineNumberType? openXmlElement, DocumentModel.Wordprocessing.LineNumberRestartKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Restart = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues, DocumentModel.Wordprocessing.LineNumberRestartKind>(value);
  }
  
}
