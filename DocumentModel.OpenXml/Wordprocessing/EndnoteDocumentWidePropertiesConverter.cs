using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using EndnoteDocumentWideProperties = DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties;
using FootnoteEndnoteSeparatorReferenceType = DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType;
using NumberingFormat = DocumentModel.Wordprocessing.NumberingFormat;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Document-Wide Endnote Properties.
/// </summary>
public static class EndnoteDocumentWidePropertiesConverter
{
  /// <summary>
  ///   Endnote Placement.
  /// </summary>
  public static EndnotePositionKind? GetEndnotePosition(EndnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EndnotePosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<EndnotePositionValues, EndnotePositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetEndnotePosition(EndnoteDocumentWideProperties? openXmlElement, EndnotePositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EndnotePosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<EndnotePosition, EndnotePositionValues, EndnotePositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Endnote Numbering Format.
  /// </summary>
  public static NumberingFormat? GetNumberingFormat(EndnoteDocumentWideProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
    if (itemElement != null)
      return NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(EndnoteDocumentWideProperties? openXmlElement, NumberingFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public static UInt16? GetNumberingStart(EndnoteDocumentWideProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberingStart>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetNumberingStart(EndnoteDocumentWideProperties? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new NumberingStart { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public static RestartNumberKind? GetNumberingRestart(EndnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingRestart>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<RestartNumberValues, RestartNumberKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNumberingRestart(EndnoteDocumentWideProperties? openXmlElement, RestartNumberKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingRestart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<NumberingRestart, RestartNumberValues, RestartNumberKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<FootnoteEndnoteSeparatorReferenceType>? GetEndnoteSpecialReferences(EndnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<FootnoteEndnoteSeparatorReferenceType>();
      foreach (var item in openXmlElement.Elements<EndnoteSpecialReference>())
      {
        var newItem = FootnoteEndnoteSeparatorReferenceTypeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetEndnoteSpecialReferences(EndnoteDocumentWideProperties? openXmlElement, Collection<FootnoteEndnoteSeparatorReferenceType>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<EndnoteSpecialReference>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = FootnoteEndnoteSeparatorReferenceTypeConverter.CreateOpenXmlElement<EndnoteSpecialReference>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.EndnoteDocumentWideProperties? CreateModelElement(EndnoteDocumentWideProperties? openXmlElement)
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
    where OpenXmlElementType : EndnoteDocumentWideProperties, new()
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