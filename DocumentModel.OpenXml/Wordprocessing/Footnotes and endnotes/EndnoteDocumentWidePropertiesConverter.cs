namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.EndnoteDocumentWideProperties"/> class from/to OpenXml converter.
/// </summary>
public static class EndnoteDocumentWidePropertiesConverter
{
  /// <summary>
  /// Endnote Placement.
  /// </summary>
  private static DMW.EndnotePositionKind? GetEndnotePosition(DXW.EndnoteDocumentWideProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.EndnotePositionValues, DMW.EndnotePositionKind>(openXmlElement.GetFirstChild<DXW.EndnotePosition>()?.Val?.Value);
  }
  
  private static bool CmpEndnotePosition(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.EndnotePositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.EndnotePositionValues, DMW.EndnotePositionKind>(openXmlElement.GetFirstChild<DXW.EndnotePosition>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetEndnotePosition(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.EndnotePositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndnotePosition>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.EndnotePositionValues, DMW.EndnotePositionKind>(itemElement, (DMW.EndnotePositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.EndnotePosition, DXW.EndnotePositionValues, DMW.EndnotePositionKind>((DMW.EndnotePositionKind)value));
  }
  
  /// <summary>
  /// Endnote Numbering Format.
  /// </summary>
  private static DMW.NumberingFormat? GetNumberingFormat(DXW.EndnoteDocumentWideProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingFormat>();
    if (element != null)
      return DMXW.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingFormat>(), value, diffs, objName);
  }
  
  private static void SetNumberingFormat(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.NumberingFormat? value)
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
  private static UInt16? GetNumberingStart(DXW.EndnoteDocumentWideProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.NumberingStart>()?.Val);
  }
  
  private static bool CmpNumberingStart(DXW.EndnoteDocumentWideProperties openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.NumberingStart>()?.Val, value, diffs, objName, "NumberingStart");
  }
  
  private static void SetNumberingStart(DXW.EndnoteDocumentWideProperties openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXW.NumberingStart,System.UInt16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  private static DMW.RestartNumberKind? GetNumberingRestart(DXW.EndnoteDocumentWideProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.RestartNumberValues, DMW.RestartNumberKind>(openXmlElement.GetFirstChild<DXW.NumberingRestart>()?.Val?.Value);
  }
  
  private static bool CmpNumberingRestart(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.RestartNumberKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.RestartNumberValues, DMW.RestartNumberKind>(openXmlElement.GetFirstChild<DXW.NumberingRestart>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetNumberingRestart(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.RestartNumberKind? value)
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
  
  private static DMW.EndnoteSeparators? GetEndnoteSpecialReferences(DXW.EndnoteDocumentWideProperties openXmlElement, DXW.Settings? settings)
  {
    var collection = new DMW.EndnoteSeparators();
    foreach (var item in openXmlElement.Elements<DXW.EndnoteSpecialReference>())
    {
      var newItem = DMXW.EndnoteSeparatorConverter.CreateModelElement(item, settings);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpEndnoteSpecialReferences(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.EndnoteSeparators? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.EndnoteSpecialReference>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.EndnoteSeparatorConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetEndnoteSpecialReferences(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.EndnoteSeparators? value, 
    DXW.Settings? settings)
  {
    openXmlElement.RemoveAllChildren<DXW.EndnoteSpecialReference>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.EndnoteSeparatorConverter.CreateOpenXmlElement(item, settings);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMW.EndnoteDocumentWideProperties? CreateModelElement(DXW.EndnoteDocumentWideProperties? openXmlElement, 
    DXW.Settings? settings)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.EndnoteDocumentWideProperties();
      value.EndnotePosition = GetEndnotePosition(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberingStart = GetNumberingStart(openXmlElement);
      value.NumberingRestart = GetNumberingRestart(openXmlElement);
      value.EndnoteSeparators = GetEndnoteSpecialReferences(openXmlElement, settings);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.EndnoteDocumentWideProperties? openXmlElement, DMW.EndnoteDocumentWideProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEndnotePosition(openXmlElement, value.EndnotePosition, diffs, objName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName))
        ok = false;
      if (!CmpNumberingStart(openXmlElement, value.NumberingStart, diffs, objName))
        ok = false;
      if (!CmpNumberingRestart(openXmlElement, value.NumberingRestart, diffs, objName))
        ok = false;
      if (!CmpEndnoteSpecialReferences(openXmlElement, value.EndnoteSeparators, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.EndnoteDocumentWideProperties CreateOpenXmlElement(DMW.EndnoteDocumentWideProperties value, DXW.Settings? settings = null)
  {
    var openXmlElement = new DXW.EndnoteDocumentWideProperties();
    UpdateOpenXmlElement(openXmlElement, value, settings);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.EndnoteDocumentWideProperties value,
    DXW.Settings? settings)
  {
    SetEndnotePosition(openXmlElement, value?.EndnotePosition);
    SetNumberingFormat(openXmlElement, value?.NumberingFormat);
    SetNumberingStart(openXmlElement, value?.NumberingStart);
    SetNumberingRestart(openXmlElement, value?.NumberingRestart);
    SetEndnoteSpecialReferences(openXmlElement, value?.EndnoteSeparators, settings);
  }
}
