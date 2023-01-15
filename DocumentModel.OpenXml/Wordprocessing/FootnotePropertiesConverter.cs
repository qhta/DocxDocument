using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using FootnoteProperties = DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties;
using NumberingFormat = DocumentModel.Wordprocessing.NumberingFormat;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the FootnoteProperties Class.
/// </summary>
public static class FootnotePropertiesConverter
{
  /// <summary>
  ///   Footnote Placement.
  /// </summary>
  public static FootnotePositionKind? GetFootnotePosition(FootnoteProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FootnotePosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<FootnotePositionValues, FootnotePositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetFootnotePosition(FootnoteProperties? openXmlElement, FootnotePositionKind? value)
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
  public static NumberingFormat? GetNumberingFormat(FootnoteProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
    if (itemElement != null)
      return NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(FootnoteProperties? openXmlElement, NumberingFormat? value)
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
  public static UInt16? GetNumberingStart(FootnoteProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberingStart>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetNumberingStart(FootnoteProperties? openXmlElement, UInt16? value)
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
  public static RestartNumberKind? GetNumberingRestart(FootnoteProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingRestart>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<RestartNumberValues, RestartNumberKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNumberingRestart(FootnoteProperties? openXmlElement, RestartNumberKind? value)
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

  public static DocumentModel.Wordprocessing.FootnoteProperties? CreateModelElement(FootnoteProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FootnoteProperties();
      value.FootnotePosition = GetFootnotePosition(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberingStart = GetNumberingStart(openXmlElement);
      value.NumberingRestart = GetNumberingRestart(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FootnoteProperties? value)
    where OpenXmlElementType : FootnoteProperties, new()
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