namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document-Wide Endnote Properties.
/// </summary>
public static class EndnoteDocumentWidePropertiesConverter
{
  /// <summary>
  /// Endnote Placement.
  /// </summary>
  public static DocumentModel.Wordprocessing.EndnotePositionKind? GetEndnotePosition(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnotePosition>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DocumentModel.Wordprocessing.EndnotePositionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetEndnotePosition(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? openXmlElement, DocumentModel.Wordprocessing.EndnotePositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnotePosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EndnotePosition, DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DocumentModel.Wordprocessing.EndnotePositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Endnote Numbering Format.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? openXmlElement, DocumentModel.Wordprocessing.NumberingFormat? value)
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
  public static UInt16? GetNumberingStart(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingStart>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetNumberingStart(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? openXmlElement, UInt16? value)
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
  public static DocumentModel.Wordprocessing.RestartNumberKind? GetNumberingRestart(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? openXmlElement)
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
  
  public static void SetNumberingRestart(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? openXmlElement, DocumentModel.Wordprocessing.RestartNumberKind? value)
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
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>? GetEndnoteSpecialReferences(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.EndnoteSpecialReference>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceTypeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetEndnoteSpecialReferences(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.EndnoteSpecialReference>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EndnoteSpecialReference>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.EndnoteDocumentWideProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.EndnoteDocumentWideProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties, new()
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
