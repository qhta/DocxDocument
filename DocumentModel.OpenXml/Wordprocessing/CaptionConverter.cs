namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Caption Type Definition converter from/to OpenXml.
///</summary>
public static class CaptionConverter
{
  /// <summary>
  /// Caption Type Name
  /// </summary>
  private static String? GetName(DXW.Caption openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXW.Caption openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXW.Caption openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Automatic Caption Placement
  /// </summary>
  private static DMW.CaptionPositionKind? GetPosition(DXW.Caption openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CaptionPositionValues, DMW.CaptionPositionKind>(openXmlElement?.Position?.Value);
  }
  
  private static bool CmpPosition(DXW.Caption openXmlElement, DMW.CaptionPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CaptionPositionValues, DMW.CaptionPositionKind>(openXmlElement?.Position?.Value, value, diffs, objName);
  }
  
  private static void SetPosition(DXW.Caption openXmlElement, DMW.CaptionPositionKind? value)
  {
    openXmlElement.Position = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CaptionPositionValues, DMW.CaptionPositionKind>(value);
  }
  
  /// <summary>
  /// Include Chapter Number in Field for Caption
  /// </summary>
  private static Boolean? GetChapterNumber(DXW.Caption openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.ChapterNumber);
  }
  
  private static bool CmpChapterNumber(DXW.Caption openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.ChapterNumber, value, diffs, objName, "ChapterNumber");
  }
  
  private static void SetChapterNumber(DXW.Caption openXmlElement, Boolean? value)
  {
    openXmlElement.ChapterNumber = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Style for Chapter Headings
  /// </summary>
  private static Int32? GetHeading(DXW.Caption openXmlElement)
  {
    return openXmlElement?.Heading?.Value;
  }
  
  private static bool CmpHeading(DXW.Caption openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Heading?.Value == value) return true;
    diffs?.Add(objName, "Heading", openXmlElement?.Heading?.Value, value);
    return false;
  }
  
  private static void SetHeading(DXW.Caption openXmlElement, Int32? value)
  {
    openXmlElement.Heading = value;
  }
  
  /// <summary>
  /// Do Not Include Name In Caption
  /// </summary>
  private static Boolean? GetNoLabel(DXW.Caption openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.NoLabel);
  }
  
  private static bool CmpNoLabel(DXW.Caption openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.NoLabel, value, diffs, objName, "NoLabel");
  }
  
  private static void SetNoLabel(DXW.Caption openXmlElement, Boolean? value)
  {
    openXmlElement.NoLabel = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Caption Numbering Format
  /// </summary>
  private static DMW.NumberFormatKind? GetNumberFormat(DXW.Caption openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DMW.NumberFormatKind>(openXmlElement?.NumberFormat?.Value);
  }
  
  private static bool CmpNumberFormat(DXW.Caption openXmlElement, DMW.NumberFormatKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DMW.NumberFormatKind>(openXmlElement?.NumberFormat?.Value, value, diffs, objName);
  }
  
  private static void SetNumberFormat(DXW.Caption openXmlElement, DMW.NumberFormatKind? value)
  {
    openXmlElement.NumberFormat = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DMW.NumberFormatKind>(value);
  }
  
  /// <summary>
  /// Chapter Number/Item Index Separator
  /// </summary>
  private static DMW.ChapterSeparatorKind? GetSeparator(DXW.Caption openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues, DMW.ChapterSeparatorKind>(openXmlElement?.Separator?.Value);
  }
  
  private static bool CmpSeparator(DXW.Caption openXmlElement, DMW.ChapterSeparatorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues, DMW.ChapterSeparatorKind>(openXmlElement?.Separator?.Value, value, diffs, objName);
  }
  
  private static void SetSeparator(DXW.Caption openXmlElement, DMW.ChapterSeparatorKind? value)
  {
    openXmlElement.Separator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues, DMW.ChapterSeparatorKind>(value);
  }
  
  public static DMW.Caption? CreateModelElement(DXW.Caption? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Caption();
      value.Name = GetName(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.ChapterNumber = GetChapterNumber(openXmlElement);
      value.Heading = GetHeading(openXmlElement);
      value.NoLabel = GetNoLabel(openXmlElement);
      value.NumberFormat = GetNumberFormat(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Caption? openXmlElement, DMW.Caption? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      if (!CmpChapterNumber(openXmlElement, value.ChapterNumber, diffs, objName))
        ok = false;
      if (!CmpHeading(openXmlElement, value.Heading, diffs, objName))
        ok = false;
      if (!CmpNoLabel(openXmlElement, value.NoLabel, diffs, objName))
        ok = false;
      if (!CmpNumberFormat(openXmlElement, value.NumberFormat, diffs, objName))
        ok = false;
      if (!CmpSeparator(openXmlElement, value.Separator, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Caption value)
    where OpenXmlElementType: DXW.Caption, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Caption openXmlElement, DMW.Caption value)
  {
    SetName(openXmlElement, value?.Name);
    SetPosition(openXmlElement, value?.Position);
    SetChapterNumber(openXmlElement, value?.ChapterNumber);
    SetHeading(openXmlElement, value?.Heading);
    SetNoLabel(openXmlElement, value?.NoLabel);
    SetNumberFormat(openXmlElement, value?.NumberFormat);
    SetSeparator(openXmlElement, value?.Separator);
  }
}
