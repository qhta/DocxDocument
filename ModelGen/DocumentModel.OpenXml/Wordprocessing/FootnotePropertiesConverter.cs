namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FootnoteProperties Class.
/// </summary>
public static class FootnotePropertiesConverter
{
  /// <summary>
  /// Footnote Placement.
  /// </summary>
  private static DMW.FootnotePositionKind? GetFootnotePosition(DXW.FootnoteProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DMW.FootnotePositionKind>(openXmlElement.GetFirstChild<DXW.FootnotePosition>()?.Val?.Value);
  }
  
  private static bool CmpFootnotePosition(DXW.FootnoteProperties openXmlElement, DMW.FootnotePositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DMW.FootnotePositionKind>(openXmlElement.GetFirstChild<DXW.FootnotePosition>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFootnotePosition(DXW.FootnoteProperties openXmlElement, DMW.FootnotePositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FootnotePosition>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DMW.FootnotePositionKind>(itemElement, (DMW.FootnotePositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.FootnotePosition, DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DMW.FootnotePositionKind>((DMW.FootnotePositionKind)value));
  }
  
  /// <summary>
  /// Footnote Numbering Format.
  /// </summary>
  private static DMW.NumberingFormat? GetNumberingFormat(DXW.FootnoteProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingFormat>();
    if (element != null)
      return DMXW.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXW.FootnoteProperties openXmlElement, DMW.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingFormat(DXW.FootnoteProperties openXmlElement, DMW.NumberingFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.NumberingFormatConverter.CreateOpenXmlElement<DXW.NumberingFormat>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  private static UInt16? GetNumberingStart(DXW.FootnoteProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.NumberingStart>()?.Val);
  }
  
  private static bool CmpNumberingStart(DXW.FootnoteProperties openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.NumberingStart>()?.Val, value, diffs, objName, "NumberingStart");
  }
  
  private static void SetNumberingStart(DXW.FootnoteProperties openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXW.NumberingStart,System.UInt16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  private static DMW.RestartNumberKind? GetNumberingRestart(DXW.FootnoteProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DMW.RestartNumberKind>(openXmlElement.GetFirstChild<DXW.NumberingRestart>()?.Val?.Value);
  }
  
  private static bool CmpNumberingRestart(DXW.FootnoteProperties openXmlElement, DMW.RestartNumberKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DMW.RestartNumberKind>(openXmlElement.GetFirstChild<DXW.NumberingRestart>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingRestart(DXW.FootnoteProperties openXmlElement, DMW.RestartNumberKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingRestart>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DMW.RestartNumberKind>(itemElement, (DMW.RestartNumberKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.NumberingRestart, DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DMW.RestartNumberKind>((DMW.RestartNumberKind)value));
  }
  
  public static DocumentModel.Wordprocessing.FootnoteProperties? CreateModelElement(DXW.FootnoteProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FootnoteProperties();
      value.FootnotePosition = GetFootnotePosition(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberingStart = GetNumberingStart(openXmlElement);
      value.NumberingRestart = GetNumberingRestart(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FootnoteProperties? openXmlElement, DMW.FootnoteProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFootnotePosition(openXmlElement, value.FootnotePosition, diffs, objName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName))
        ok = false;
      if (!CmpNumberingStart(openXmlElement, value.NumberingStart, diffs, objName))
        ok = false;
      if (!CmpNumberingRestart(openXmlElement, value.NumberingRestart, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FootnoteProperties value)
    where OpenXmlElementType: DXW.FootnoteProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FootnoteProperties openXmlElement, DMW.FootnoteProperties value)
  {
    SetFootnotePosition(openXmlElement, value?.FootnotePosition);
    SetNumberingFormat(openXmlElement, value?.NumberingFormat);
    SetNumberingStart(openXmlElement, value?.NumberingStart);
    SetNumberingRestart(openXmlElement, value?.NumberingRestart);
  }
}
