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
    var itemElement = openXmlElement.GetFirstChild<DXW.FootnotePosition>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DMW.FootnotePositionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetFootnotePosition(DXW.FootnoteDocumentWideProperties openXmlElement, DMW.FootnotePositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FootnotePosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.FootnotePosition, DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DMW.FootnotePositionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Footnote Numbering Format.
  /// </summary>
  private static DMW.NumberingFormat? GetNumberingFormat(DXW.FootnoteDocumentWideProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.NumberingFormat>();
    if (itemElement != null)
      return DMXW.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  private static UInt16? GetNumberingStart(DXW.FootnoteDocumentWideProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.NumberingStart>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetNumberingStart(DXW.FootnoteDocumentWideProperties openXmlElement, UInt16? value)
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
  private static DMW.RestartNumberKind? GetNumberingRestart(DXW.FootnoteDocumentWideProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingRestart>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DMW.RestartNumberKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNumberingRestart(DXW.FootnoteDocumentWideProperties openXmlElement, DMW.RestartNumberKind? value)
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
  
  private static Collection<DMW.FootnoteEndnoteSeparatorReferenceType> GetFootnoteSpecialReferences(DXW.FootnoteDocumentWideProperties openXmlElement)
  {
    var collection = new Collection<DMW.FootnoteEndnoteSeparatorReferenceType>();
    foreach (var item in openXmlElement.Elements<DXW.FootnoteSpecialReference>())
    {
      var newItem = DMXW.FootnoteEndnoteSeparatorReferenceTypeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetFootnoteSpecialReferences(DXW.FootnoteDocumentWideProperties openXmlElement, Collection<DMW.FootnoteEndnoteSeparatorReferenceType>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.FootnoteSpecialReference>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.FootnoteEndnoteSeparatorReferenceTypeConverter.CreateOpenXmlElement<DXW.FootnoteSpecialReference>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.FootnoteDocumentWideProperties? CreateModelElement(DXW.FootnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FootnoteDocumentWideProperties();
      value.FootnotePosition = GetFootnotePosition(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberingStart = GetNumberingStart(openXmlElement);
      value.NumberingRestart = GetNumberingRestart(openXmlElement);
      value.FootnoteSpecialReferences = GetFootnoteSpecialReferences(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FootnoteDocumentWideProperties? value)
    where OpenXmlElementType: DXW.FootnoteDocumentWideProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFootnotePosition(openXmlElement, value?.FootnotePosition);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetNumberingStart(openXmlElement, value?.NumberingStart);
      SetNumberingRestart(openXmlElement, value?.NumberingRestart);
      SetFootnoteSpecialReferences(openXmlElement, value?.FootnoteSpecialReferences);
      return openXmlElement;
    }
    return default;
  }
}
