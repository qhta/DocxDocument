using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using EastAsianLayout = DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the EastAsianLayout Class.
/// </summary>
public static class EastAsianLayoutConverter
{
  /// <summary>
  ///   East Asian Typography Run ID
  /// </summary>
  public static Int32? GetId(EastAsianLayout? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(EastAsianLayout? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  /// <summary>
  ///   Two Lines in One
  /// </summary>
  public static Boolean? GetCombine(EastAsianLayout? openXmlElement)
  {
    return openXmlElement?.Combine?.Value;
  }

  public static void SetCombine(EastAsianLayout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Combine = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Combine = null;
  }

  /// <summary>
  ///   Display Brackets Around Two Lines in One
  /// </summary>
  public static CombineBracketKind? GetCombineBrackets(EastAsianLayout? openXmlElement)
  {
    return EnumValueConverter.GetValue<CombineBracketValues, CombineBracketKind>(openXmlElement?.CombineBrackets?.Value);
  }

  public static void SetCombineBrackets(EastAsianLayout? openXmlElement, CombineBracketKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CombineBrackets = EnumValueConverter.CreateEnumValue<CombineBracketValues, CombineBracketKind>(value);
  }

  /// <summary>
  ///   Horizontal in Vertical (Rotate Text)
  /// </summary>
  public static Boolean? GetVertical(EastAsianLayout? openXmlElement)
  {
    return openXmlElement?.Vertical?.Value;
  }

  public static void SetVertical(EastAsianLayout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Vertical = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Vertical = null;
  }

  /// <summary>
  ///   Compress Rotated Text to Line Height
  /// </summary>
  public static Boolean? GetVerticalCompress(EastAsianLayout? openXmlElement)
  {
    return openXmlElement?.VerticalCompress?.Value;
  }

  public static void SetVerticalCompress(EastAsianLayout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.VerticalCompress = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.VerticalCompress = null;
  }

  public static DocumentModel.Wordprocessing.EastAsianLayout? CreateModelElement(EastAsianLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.EastAsianLayout();
      value.Id = GetId(openXmlElement);
      value.Combine = GetCombine(openXmlElement);
      value.CombineBrackets = GetCombineBrackets(openXmlElement);
      value.Vertical = GetVertical(openXmlElement);
      value.VerticalCompress = GetVerticalCompress(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.EastAsianLayout? value)
    where OpenXmlElementType : EastAsianLayout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetCombine(openXmlElement, value?.Combine);
      SetCombineBrackets(openXmlElement, value?.CombineBrackets);
      SetVertical(openXmlElement, value?.Vertical);
      SetVerticalCompress(openXmlElement, value?.VerticalCompress);
      return openXmlElement;
    }
    return default;
  }
}