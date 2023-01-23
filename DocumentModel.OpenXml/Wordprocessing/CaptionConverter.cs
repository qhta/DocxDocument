namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Caption Type Definition.
/// </summary>
public static class CaptionConverter
{
  /// <summary>
  /// Caption Type Name
  /// </summary>
  private static String? GetName(DXW.Caption openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXW.Caption openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXW.Caption openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CaptionPositionValues, DMW.CaptionPositionKind>(openXmlElement?.Position?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.ChapterNumber?.Value;
  }
  
  private static bool CmpChapterNumber(DXW.Caption openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ChapterNumber?.Value == value;
  }
  
  private static void SetChapterNumber(DXW.Caption openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ChapterNumber = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.ChapterNumber = null;
  }
  
  /// <summary>
  /// Style for Chapter Headings
  /// </summary>
  private static Int32? GetHeading(DXW.Caption openXmlElement)
  {
    return openXmlElement.Heading?.Value;
  }
  
  private static bool CmpHeading(DXW.Caption openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Heading?.Value == value;
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
    return openXmlElement?.NoLabel?.Value;
  }
  
  private static bool CmpNoLabel(DXW.Caption openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoLabel?.Value == value;
  }
  
  private static void SetNoLabel(DXW.Caption openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoLabel = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.NoLabel = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DMW.NumberFormatKind>(openXmlElement?.NumberFormat?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues, DMW.ChapterSeparatorKind>(openXmlElement?.Separator?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Caption? value)
    where OpenXmlElementType: DXW.Caption, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetPosition(openXmlElement, value?.Position);
      SetChapterNumber(openXmlElement, value?.ChapterNumber);
      SetHeading(openXmlElement, value?.Heading);
      SetNoLabel(openXmlElement, value?.NoLabel);
      SetNumberFormat(openXmlElement, value?.NumberFormat);
      SetSeparator(openXmlElement, value?.Separator);
      return openXmlElement;
    }
    return default;
  }
}
