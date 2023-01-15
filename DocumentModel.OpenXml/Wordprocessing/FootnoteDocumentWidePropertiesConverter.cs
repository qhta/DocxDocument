using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using FootnoteDocumentWideProperties = DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties;
using FootnoteEndnoteSeparatorReferenceType = DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType;
using NumberingFormat = DocumentModel.Wordprocessing.NumberingFormat;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Document-Wide Footnote Properties.
/// </summary>
public static class FootnoteDocumentWidePropertiesConverter
{
  /// <summary>
  ///   Footnote Placement.
  /// </summary>
  public static FootnotePositionKind? GetFootnotePosition(FootnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FootnotePosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<FootnotePositionValues, FootnotePositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetFootnotePosition(FootnoteDocumentWideProperties? openXmlElement, FootnotePositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FootnotePosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<FootnotePosition, FootnotePositionValues, FootnotePositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Footnote Numbering Format.
  /// </summary>
  public static NumberingFormat? GetNumberingFormat(FootnoteDocumentWideProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
    if (itemElement != null)
      return NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(FootnoteDocumentWideProperties? openXmlElement, NumberingFormat? value)
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
  public static UInt16? GetNumberingStart(FootnoteDocumentWideProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberingStart>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetNumberingStart(FootnoteDocumentWideProperties? openXmlElement, UInt16? value)
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
  public static RestartNumberKind? GetNumberingRestart(FootnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingRestart>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<RestartNumberValues, RestartNumberKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNumberingRestart(FootnoteDocumentWideProperties? openXmlElement, RestartNumberKind? value)
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

  public static Collection<FootnoteEndnoteSeparatorReferenceType>? GetFootnoteSpecialReferences(FootnoteDocumentWideProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<FootnoteEndnoteSeparatorReferenceType>();
      foreach (var item in openXmlElement.Elements<FootnoteSpecialReference>())
      {
        var newItem = FootnoteEndnoteSeparatorReferenceTypeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetFootnoteSpecialReferences(FootnoteDocumentWideProperties? openXmlElement, Collection<FootnoteEndnoteSeparatorReferenceType>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<FootnoteSpecialReference>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = FootnoteEndnoteSeparatorReferenceTypeConverter.CreateOpenXmlElement<FootnoteSpecialReference>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.FootnoteDocumentWideProperties? CreateModelElement(FootnoteDocumentWideProperties? openXmlElement)
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
    where OpenXmlElementType : FootnoteDocumentWideProperties, new()
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