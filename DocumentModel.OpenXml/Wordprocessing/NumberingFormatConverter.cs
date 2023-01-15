using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using NumberingFormat = DocumentFormat.OpenXml.Wordprocessing.NumberingFormat;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Footnote Numbering Format.
/// </summary>
public static class NumberingFormatConverter
{
  /// <summary>
  ///   Numbering Format Type
  /// </summary>
  public static NumberFormatKind? GetVal(NumberingFormat? openXmlElement)
  {
    return EnumValueConverter.GetValue<NumberFormatValues, NumberFormatKind>(openXmlElement?.Val?.Value);
  }

  public static void SetVal(NumberingFormat? openXmlElement, NumberFormatKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<NumberFormatValues, NumberFormatKind>(value);
  }

  /// <summary>
  ///   format, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetFormat(NumberingFormat? openXmlElement)
  {
    return openXmlElement?.Format?.Value;
  }

  public static void SetFormat(NumberingFormat? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Format = new StringValue { Value = value };
      else
        openXmlElement.Format = null;
  }

  public static DocumentModel.Wordprocessing.NumberingFormat? CreateModelElement(NumberingFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingFormat();
      value.Val = GetVal(openXmlElement);
      value.Format = GetFormat(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.NumberingFormat? value)
    where OpenXmlElementType : NumberingFormat, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetFormat(openXmlElement, value?.Format);
      return openXmlElement;
    }
    return default;
  }
}