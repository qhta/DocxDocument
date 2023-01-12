namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document-Wide Footnote Properties.
/// </summary>
public static class FootnoteDocumentWidePropertiesConverter
{
  /// <summary>
  /// Footnote Placement.
  /// </summary>
  public static DocumentModel.Wordprocessing.FootnotePositionKind? GetFootnotePosition(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnotePosition>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DocumentModel.Wordprocessing.FootnotePositionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetFootnotePosition(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? openXmlElement, DocumentModel.Wordprocessing.FootnotePositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnotePosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FootnotePosition, DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DocumentModel.Wordprocessing.FootnotePositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Footnote Numbering Format.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? openXmlElement, DocumentModel.Wordprocessing.NumberingFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.NumberingFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public static UInt16? GetNumberingStart(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingStart>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetNumberingStart(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.NumberingStart{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public static DocumentModel.Wordprocessing.RestartNumberKind? GetNumberingRestart(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingRestart>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DocumentModel.Wordprocessing.RestartNumberKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetNumberingRestart(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? openXmlElement, DocumentModel.Wordprocessing.RestartNumberKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingRestart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingRestart, DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DocumentModel.Wordprocessing.RestartNumberKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>? GetFootnoteSpecialReferences(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.FootnoteSpecialReference>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceTypeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetFootnoteSpecialReferences(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.FootnoteSpecialReference>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FootnoteSpecialReference>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.FootnoteDocumentWideProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FootnoteDocumentWideProperties();
      value.FootnotePosition = GetFootnotePosition(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberingStart = GetNumberingStart(openXmlElement);
      value.NumberingRestart = GetNumberingRestart(openXmlElement);
      value.FootnoteSpecialReferences = GetFootnoteSpecialReferences(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FootnoteDocumentWideProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFootnotePosition(openXmlElement, value?.FootnotePosition);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetNumberingStart(openXmlElement, value?.NumberingStart);
      SetNumberingRestart(openXmlElement, value?.NumberingRestart);
      return openXmlElement;
    }
    return default;
  }
}
