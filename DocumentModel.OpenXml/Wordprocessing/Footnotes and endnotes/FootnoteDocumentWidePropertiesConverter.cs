namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document-Wide Footnote Properties.
/// </summary>
public static class FootnoteDocumentWidePropertiesConverter
{
  /// <summary>
  /// Footnote Placement.
  /// </summary>
  private static DMW.FootnotePositionKind? GetFootnotePosition(DXW.FootnoteDocumentWideProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.FootnotePositionValues, DMW.FootnotePositionKind>(openXmlElement.GetFirstChild<DXW.FootnotePosition>()?.Val?.Value);
  }
  
  private static bool CmpFootnotePosition(DXW.FootnoteDocumentWideProperties openXmlElement, DMW.FootnotePositionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.FootnotePositionValues, DMW.FootnotePositionKind>(openXmlElement.GetFirstChild<DXW.FootnotePosition>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetFootnotePosition(DXW.FootnoteDocumentWideProperties openXmlElement, DMW.FootnotePositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FootnotePosition>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.FootnotePositionValues, DMW.FootnotePositionKind>(itemElement, (DMW.FootnotePositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.FootnotePosition, DXW.FootnotePositionValues, DMW.FootnotePositionKind>((DMW.FootnotePositionKind)value));
  }
  
  /// <summary>
  /// Footnote Numbering Format.
  /// </summary>
  private static DMW.NumberingFormat? GetNumberingFormat(DXW.FootnoteDocumentWideProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingFormat>();
    if (element != null)
      return DMXW.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXW.FootnoteDocumentWideProperties openXmlElement, DMW.NumberingFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingFormat>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberingFormat(DXW.FootnoteDocumentWideProperties openXmlElement, DMW.NumberingFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.NumberingFormatConverter.CreateOpenXmlElement<DXW.NumberingFormat>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  private static UInt16? GetNumberingStart(DXW.FootnoteDocumentWideProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.NumberingStart>()?.Val);
  }
  
  private static bool CmpNumberingStart(DXW.FootnoteDocumentWideProperties openXmlElement, UInt16? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.NumberingStart>()?.Val, value, diffs, objName, "NumberingStart");
  }
  
  private static void SetNumberingStart(DXW.FootnoteDocumentWideProperties openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXW.NumberingStart,System.UInt16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  private static DMW.RestartNumberKind? GetNumberingRestart(DXW.FootnoteDocumentWideProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.RestartNumberValues, DMW.RestartNumberKind>(openXmlElement.GetFirstChild<DXW.NumberingRestart>()?.Val?.Value);
  }
  
  private static bool CmpNumberingRestart(DXW.FootnoteDocumentWideProperties openXmlElement, DMW.RestartNumberKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.RestartNumberValues, DMW.RestartNumberKind>(openXmlElement.GetFirstChild<DXW.NumberingRestart>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetNumberingRestart(DXW.FootnoteDocumentWideProperties openXmlElement, DMW.RestartNumberKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingRestart>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.RestartNumberValues, DMW.RestartNumberKind>(itemElement, (DMW.RestartNumberKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.NumberingRestart, DXW.RestartNumberValues, DMW.RestartNumberKind>((DMW.RestartNumberKind)value));
  }
  
  private static DMW.FootnoteSeparators? GetFootnoteSpecialReferences(DXW.FootnoteDocumentWideProperties openXmlElement, DXW.Settings? settings)
  {
    var collection = new DMW.FootnoteSeparators();
    foreach (var item in openXmlElement.Elements<DXW.FootnoteSpecialReference>())
    {
      var newItem = DMXW.FootnoteSeparatorConverter.CreateModelElement(item, settings);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpFootnoteSpecialReferences(DXW.FootnoteDocumentWideProperties openXmlElement, DMW.FootnoteSeparators? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXW.FootnoteSpecialReference>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.FootnoteSeparatorConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetFootnoteSpecialReferences(DXW.FootnoteDocumentWideProperties openXmlElement, DMW.FootnoteSeparators? value, DXW.Settings? settings)
  {
    openXmlElement.RemoveAllChildren<DXW.FootnoteSpecialReference>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.FootnoteSeparatorConverter.CreateOpenXmlElement(item, settings);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMW.FootnoteDocumentWideProperties? CreateModelElement(DXW.FootnoteDocumentWideProperties? openXmlElement, DXW.Settings? settings)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FootnoteDocumentWideProperties();
      value.FootnotePosition = GetFootnotePosition(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberingStart = GetNumberingStart(openXmlElement);
      value.NumberingRestart = GetNumberingRestart(openXmlElement);
      value.FootnoteSeparators = GetFootnoteSpecialReferences(openXmlElement, settings);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FootnoteDocumentWideProperties? openXmlElement, DMW.FootnoteDocumentWideProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFootnotePosition(openXmlElement, value.FootnotePosition, diffs, objName, propName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName, propName))
        ok = false;
      if (!CmpNumberingStart(openXmlElement, value.NumberingStart, diffs, objName, propName))
        ok = false;
      if (!CmpNumberingRestart(openXmlElement, value.NumberingRestart, diffs, objName, propName))
        ok = false;
      if (!CmpFootnoteSpecialReferences(openXmlElement, value.FootnoteSeparators, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.FootnoteDocumentWideProperties CreateOpenXmlElement(DMW.FootnoteDocumentWideProperties value, DXW.Settings? settings)
  {
    var openXmlElement = new DXW.FootnoteDocumentWideProperties();
    UpdateOpenXmlElement(openXmlElement, value, settings);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FootnoteDocumentWideProperties openXmlElement, DMW.FootnoteDocumentWideProperties value, DXW.Settings? settings)
  {
    SetFootnotePosition(openXmlElement, value?.FootnotePosition);
    SetNumberingFormat(openXmlElement, value?.NumberingFormat);
    SetNumberingStart(openXmlElement, value?.NumberingStart);
    SetNumberingRestart(openXmlElement, value?.NumberingRestart);
    SetFootnoteSpecialReferences(openXmlElement, value?.FootnoteSeparators, settings);
  }
}
