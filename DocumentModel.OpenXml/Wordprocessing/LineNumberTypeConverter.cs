namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LineNumberType Class.
/// </summary>
public static class LineNumberTypeConverter
{
  /// <summary>
  /// Line Number Increments to Display
  /// </summary>
  private static Int16? GetCountBy(DXW.LineNumberType openXmlElement)
  {
    return openXmlElement.CountBy?.Value;
  }
  
  private static void SetCountBy(DXW.LineNumberType openXmlElement, Int16? value)
  {
    openXmlElement.CountBy = value;
  }
  
  /// <summary>
  /// Line Numbering Starting Value
  /// </summary>
  private static Int16? GetStart(DXW.LineNumberType openXmlElement)
  {
    return openXmlElement.Start?.Value;
  }
  
  private static void SetStart(DXW.LineNumberType openXmlElement, Int16? value)
  {
    openXmlElement.Start = value;
  }
  
  /// <summary>
  /// Distance Between Text and Line Numbering
  /// </summary>
  private static String? GetDistance(DXW.LineNumberType openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }
  
  private static void SetDistance(DXW.LineNumberType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Distance = new StringValue { Value = value };
    else
      openXmlElement.Distance = null;
  }
  
  /// <summary>
  /// Line Numbering Restart Setting
  /// </summary>
  private static DMW.LineNumberRestartKind? GetRestart(DXW.LineNumberType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues, DMW.LineNumberRestartKind>(openXmlElement?.Restart?.Value);
  }
  
  private static void SetRestart(DXW.LineNumberType openXmlElement, DMW.LineNumberRestartKind? value)
  {
    openXmlElement.Restart = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues, DMW.LineNumberRestartKind>(value);
  }
  
  public static DMW.LineNumberType? CreateModelElement(DXW.LineNumberType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LineNumberType();
      value.CountBy = GetCountBy(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.Restart = GetRestart(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.LineNumberType? value)
    where OpenXmlElementType: DXW.LineNumberType, new()
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
