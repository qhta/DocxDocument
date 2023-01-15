using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using EndnoteProperties = DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties;
using NumberingFormat = DocumentModel.Wordprocessing.NumberingFormat;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the EndnoteProperties Class.
/// </summary>
public static class EndnotePropertiesConverter
{
  /// <summary>
  ///   Endnote Placement.
  /// </summary>
  public static EndnotePositionKind? GetEndnotePosition(EndnoteProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EndnotePosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<EndnotePositionValues, EndnotePositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetEndnotePosition(EndnoteProperties? openXmlElement, EndnotePositionKind? value)
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
  public static NumberingFormat? GetNumberingFormat(EndnoteProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
    if (itemElement != null)
      return NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(EndnoteProperties? openXmlElement, NumberingFormat? value)
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
  public static UInt16? GetNumberingStart(EndnoteProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberingStart>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetNumberingStart(EndnoteProperties? openXmlElement, UInt16? value)
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
  public static RestartNumberKind? GetNumberingRestart(EndnoteProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingRestart>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<RestartNumberValues, RestartNumberKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNumberingRestart(EndnoteProperties? openXmlElement, RestartNumberKind? value)
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

  public static DocumentModel.Wordprocessing.EndnoteProperties? CreateModelElement(EndnoteProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.EndnoteProperties();
      value.EndnotePosition = GetEndnotePosition(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberingStart = GetNumberingStart(openXmlElement);
      value.NumberingRestart = GetNumberingRestart(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.EndnoteProperties? value)
    where OpenXmlElementType : EndnoteProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEndnotePosition(openXmlElement, value?.EndnotePosition);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetNumberingStart(openXmlElement, value?.NumberingStart);
      SetNumberingRestart(openXmlElement, value?.NumberingRestart);
      return openXmlElement;
    }
    return default;
  }
}