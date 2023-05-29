namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document-Wide Endnote Properties.
/// </summary>
public static class EndnoteDocumentWidePropertiesConverter
{
  /// <summary>
  /// Endnote Placement.
  /// </summary>
  private static DMW.EndnotePositionKind? GetEndnotePosition(DXW.EndnoteDocumentWideProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DMW.EndnotePositionKind>(openXmlElement.GetFirstChild<DXW.EndnotePosition>()?.Val?.Value);
  }
  
  private static bool CmpEndnotePosition(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.EndnotePositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DMW.EndnotePositionKind>(openXmlElement.GetFirstChild<DXW.EndnotePosition>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEndnotePosition(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.EndnotePositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndnotePosition>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DMW.EndnotePositionKind>(itemElement, (DMW.EndnotePositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.EndnotePosition, DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DMW.EndnotePositionKind>((DMW.EndnotePositionKind)value));
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
    return DMXW.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
        openXmlElement.AddChild(itemElement);
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DMW.RestartNumberKind>(openXmlElement.GetFirstChild<DXW.NumberingRestart>()?.Val?.Value);
  }
  
  private static bool CmpNumberingRestart(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.RestartNumberKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DMW.RestartNumberKind>(openXmlElement.GetFirstChild<DXW.NumberingRestart>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingRestart(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.RestartNumberKind? value)
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
  
  private static Collection<DMW.FootnoteEndnoteSeparatorReferenceType>? GetEndnoteSpecialReferences(DXW.EndnoteDocumentWideProperties openXmlElement)
  {
    var collection = new Collection<DMW.FootnoteEndnoteSeparatorReferenceType>();
    foreach (var item in openXmlElement.Elements<DXW.EndnoteSpecialReference>())
    {
      var newItem = DMXW.FootnoteEndnoteSeparatorReferenceTypeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpEndnoteSpecialReferences(DXW.EndnoteDocumentWideProperties openXmlElement, Collection<DMW.FootnoteEndnoteSeparatorReferenceType>? value, DiffList? diffs, string? objName)
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
        if (!DMXW.FootnoteEndnoteSeparatorReferenceTypeConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetEndnoteSpecialReferences(DXW.EndnoteDocumentWideProperties openXmlElement, Collection<DMW.FootnoteEndnoteSeparatorReferenceType>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.EndnoteSpecialReference>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.FootnoteEndnoteSeparatorReferenceTypeConverter.CreateOpenXmlElement<DXW.EndnoteSpecialReference>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.EndnoteDocumentWideProperties? CreateModelElement(DXW.EndnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.EndnoteDocumentWideProperties();
      value.EndnotePosition = GetEndnotePosition(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberingStart = GetNumberingStart(openXmlElement);
      value.NumberingRestart = GetNumberingRestart(openXmlElement);
      value.EndnoteSpecialReferences = GetEndnoteSpecialReferences(openXmlElement);
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
      if (!CmpEndnoteSpecialReferences(openXmlElement, value.EndnoteSpecialReferences, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.EndnoteDocumentWideProperties value)
    where OpenXmlElementType: DXW.EndnoteDocumentWideProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.EndnoteDocumentWideProperties value)
  {
    SetEndnotePosition(openXmlElement, value?.EndnotePosition);
    SetNumberingFormat(openXmlElement, value?.NumberingFormat);
    SetNumberingStart(openXmlElement, value?.NumberingStart);
    SetNumberingRestart(openXmlElement, value?.NumberingRestart);
    SetEndnoteSpecialReferences(openXmlElement, value?.EndnoteSpecialReferences);
  }
}
