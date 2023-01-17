namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LineNumberType Class.
/// </summary>
public static class LineNumberTypeConverter
{
  /// <summary>
  /// Line Number Increments to Display
  /// </summary>
  private static Int16? GetCountBy(DocumentFormat.OpenXml.Wordprocessing.LineNumberType openXmlElement)
  {
    return openXmlElement.CountBy?.Value;
  }
  
  private static void SetCountBy(DocumentFormat.OpenXml.Wordprocessing.LineNumberType openXmlElement, Int16? value)
  {
    openXmlElement.CountBy = value;
  }
  
  /// <summary>
  /// Line Numbering Starting Value
  /// </summary>
  private static Int16? GetStart(DocumentFormat.OpenXml.Wordprocessing.LineNumberType openXmlElement)
  {
    return openXmlElement.Start?.Value;
  }
  
  private static void SetStart(DocumentFormat.OpenXml.Wordprocessing.LineNumberType openXmlElement, Int16? value)
  {
    openXmlElement.Start = value;
  }
  
  /// <summary>
  /// Distance Between Text and Line Numbering
  /// </summary>
  private static String? GetDistance(DocumentFormat.OpenXml.Wordprocessing.LineNumberType openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }
  
  private static void SetDistance(DocumentFormat.OpenXml.Wordprocessing.LineNumberType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Distance = new StringValue { Value = value };
    else
      openXmlElement.Distance = null;
  }
  
  /// <summary>
  /// Line Numbering Restart Setting
  /// </summary>
  private static DocumentModel.Wordprocessing.LineNumberRestartKind? GetRestart(DocumentFormat.OpenXml.Wordprocessing.LineNumberType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues, DocumentModel.Wordprocessing.LineNumberRestartKind>(openXmlElement?.Restart?.Value);
  }
  
  private static void SetRestart(DocumentFormat.OpenXml.Wordprocessing.LineNumberType openXmlElement, DocumentModel.Wordprocessing.LineNumberRestartKind? value)
  {
    openXmlElement.Restart = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues, DocumentModel.Wordprocessing.LineNumberRestartKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.LineNumberType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.LineNumberType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LineNumberType();
      value.CountBy = GetCountBy(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.Restart = GetRestart(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LineNumberType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.LineNumberType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCountBy(openXmlElement, value?.CountBy);
      SetStart(openXmlElement, value?.Start);
      SetDistance(openXmlElement, value?.Distance);
      SetRestart(openXmlElement, value?.Restart);
      return openXmlElement;
    }
    return default;
  }
}
