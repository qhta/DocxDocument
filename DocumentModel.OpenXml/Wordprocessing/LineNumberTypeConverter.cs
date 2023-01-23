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
  
  private static bool CmpCountBy(DXW.LineNumberType openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.CountBy?.Value == value;
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
  
  private static bool CmpStart(DXW.LineNumberType openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Start?.Value == value;
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
  
  private static bool CmpDistance(DXW.LineNumberType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Distance?.Value == value;
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
  
  private static bool CmpRestart(DXW.LineNumberType openXmlElement, DMW.LineNumberRestartKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues, DMW.LineNumberRestartKind>(openXmlElement?.Restart?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXW.LineNumberType? openXmlElement, DMW.LineNumberType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCountBy(openXmlElement, value.CountBy, diffs, objName))
        ok = false;
      if (!CmpStart(openXmlElement, value.Start, diffs, objName))
        ok = false;
      if (!CmpDistance(openXmlElement, value.Distance, diffs, objName))
        ok = false;
      if (!CmpRestart(openXmlElement, value.Restart, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
