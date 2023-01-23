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
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.EndnotePosition, DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DMW.EndnotePositionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Endnote Numbering Format.
  /// </summary>
  private static DMW.NumberingFormat? GetNumberingFormat(DXW.EndnoteDocumentWideProperties openXmlElement)
  {
    return DMXW.NumberingFormatConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.NumberingFormat>());
  }
  
  private static bool CmpNumberingFormat(DXW.EndnoteDocumentWideProperties openXmlElement, DMW.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingFormatConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.NumberingFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.GetFirstChild<DXW.NumberingStart>()?.Val?.Value;
  }
  
  private static bool CmpNumberingStart(DXW.EndnoteDocumentWideProperties openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXW.NumberingStart>()?.Val?.Value == value;
  }
  
  private static void SetNumberingStart(DXW.EndnoteDocumentWideProperties openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.NumberingStart{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
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
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.NumberingRestart, DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DMW.RestartNumberKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.FootnoteEndnoteSeparatorReferenceType> GetEndnoteSpecialReferences(DXW.EndnoteDocumentWideProperties openXmlElement)
  {
    var collection = new Collection<DMW.FootnoteEndnoteSeparatorReferenceType>();
    foreach (var item in openXmlElement.Elements<DXW.EndnoteSpecialReference>())
    {
      var newItem = DMXW.FootnoteEndnoteSeparatorReferenceTypeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpEndnoteSpecialReferences(DXW.EndnoteDocumentWideProperties openXmlElement, Collection<DMW.FootnoteEndnoteSeparatorReferenceType>? value, DiffList? diffs, string? objName)
  {
    return true;
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
  
  public static DMW.EndnoteDocumentWideProperties? CreateModelElement(DXW.EndnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.EndnoteDocumentWideProperties();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.EndnoteDocumentWideProperties? value)
    where OpenXmlElementType: DXW.EndnoteDocumentWideProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEndnotePosition(openXmlElement, value?.EndnotePosition);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetNumberingStart(openXmlElement, value?.NumberingStart);
      SetNumberingRestart(openXmlElement, value?.NumberingRestart);
      SetEndnoteSpecialReferences(openXmlElement, value?.EndnoteSpecialReferences);
      return openXmlElement;
    }
    return default;
  }
}
