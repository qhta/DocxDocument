using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Caption = DocumentFormat.OpenXml.Wordprocessing.Caption;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Single Caption Type Definition.
/// </summary>
public static class CaptionConverter
{
  /// <summary>
  ///   Caption Type Name
  /// </summary>
  public static String? GetName(Caption? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(Caption? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   Automatic Caption Placement
  /// </summary>
  public static CaptionPositionKind? GetPosition(Caption? openXmlElement)
  {
    return EnumValueConverter.GetValue<CaptionPositionValues, CaptionPositionKind>(openXmlElement?.Position?.Value);
  }

  public static void SetPosition(Caption? openXmlElement, CaptionPositionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Position = EnumValueConverter.CreateEnumValue<CaptionPositionValues, CaptionPositionKind>(value);
  }

  /// <summary>
  ///   Include Chapter Number in Field for Caption
  /// </summary>
  public static Boolean? GetChapterNumber(Caption? openXmlElement)
  {
    return openXmlElement?.ChapterNumber?.Value;
  }

  public static void SetChapterNumber(Caption? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ChapterNumber = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.ChapterNumber = null;
  }

  /// <summary>
  ///   Style for Chapter Headings
  /// </summary>
  public static Int32? GetHeading(Caption? openXmlElement)
  {
    return openXmlElement?.Heading?.Value;
  }

  public static void SetHeading(Caption? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Heading = value;
  }

  /// <summary>
  ///   Do Not Include Name In Caption
  /// </summary>
  public static Boolean? GetNoLabel(Caption? openXmlElement)
  {
    return openXmlElement?.NoLabel?.Value;
  }

  public static void SetNoLabel(Caption? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoLabel = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.NoLabel = null;
  }

  /// <summary>
  ///   Caption Numbering Format
  /// </summary>
  public static NumberFormatKind? GetNumberFormat(Caption? openXmlElement)
  {
    return EnumValueConverter.GetValue<NumberFormatValues, NumberFormatKind>(openXmlElement?.NumberFormat?.Value);
  }

  public static void SetNumberFormat(Caption? openXmlElement, NumberFormatKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.NumberFormat = EnumValueConverter.CreateEnumValue<NumberFormatValues, NumberFormatKind>(value);
  }

  /// <summary>
  ///   Chapter Number/Item Index Separator
  /// </summary>
  public static ChapterSeparatorKind? GetSeparator(Caption? openXmlElement)
  {
    return EnumValueConverter.GetValue<ChapterSeparatorValues, ChapterSeparatorKind>(openXmlElement?.Separator?.Value);
  }

  public static void SetSeparator(Caption? openXmlElement, ChapterSeparatorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Separator = EnumValueConverter.CreateEnumValue<ChapterSeparatorValues, ChapterSeparatorKind>(value);
  }

  public static DocumentModel.Wordprocessing.Caption? CreateModelElement(Caption? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Caption();
      value.Name = GetName(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.ChapterNumber = GetChapterNumber(openXmlElement);
      value.Heading = GetHeading(openXmlElement);
      value.NoLabel = GetNoLabel(openXmlElement);
      value.NumberFormat = GetNumberFormat(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Caption? value)
    where OpenXmlElementType : Caption, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetPosition(openXmlElement, value?.Position);
      SetChapterNumber(openXmlElement, value?.ChapterNumber);
      SetHeading(openXmlElement, value?.Heading);
      SetNoLabel(openXmlElement, value?.NoLabel);
      SetNumberFormat(openXmlElement, value?.NumberFormat);
      SetSeparator(openXmlElement, value?.Separator);
      return openXmlElement;
    }
    return default;
  }
}