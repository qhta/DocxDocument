using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the TextFontType Class.
/// </summary>
public static class TextFontTypeConverter
{
  /// <summary>
  ///   Text Typeface
  /// </summary>
  public static String? GetTypeface(TextFontType? openXmlElement)
  {
    return openXmlElement?.Typeface?.Value;
  }

  public static void SetTypeface(TextFontType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Typeface = new StringValue { Value = value };
      else
        openXmlElement.Typeface = null;
  }

  /// <summary>
  ///   Panose Setting
  /// </summary>
  public static Byte[]? GetPanose(TextFontType? openXmlElement)
  {
    if (openXmlElement?.Panose?.Value != null)
      return Convert.FromHexString(openXmlElement.Panose.Value);
    return null;
  }

  public static void SetPanose(TextFontType? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Panose = Convert.ToHexString(value);
      else
        openXmlElement.Panose = null;
    }
  }

  /// <summary>
  ///   Similar Font Family
  /// </summary>
  public static SByte? GetPitchFamily(TextFontType? openXmlElement)
  {
    return openXmlElement?.PitchFamily?.Value;
  }

  public static void SetPitchFamily(TextFontType? openXmlElement, SByte? value)
  {
    if (openXmlElement != null)
      openXmlElement.PitchFamily = value;
  }

  /// <summary>
  ///   Similar Character Set
  /// </summary>
  public static SByte? GetCharacterSet(TextFontType? openXmlElement)
  {
    return openXmlElement?.CharacterSet?.Value;
  }

  public static void SetCharacterSet(TextFontType? openXmlElement, SByte? value)
  {
    if (openXmlElement != null)
      openXmlElement.CharacterSet = value;
  }

  public static DocumentModel.Drawings.TextFontType? CreateModelElement(TextFontType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TextFontType();
      value.Typeface = GetTypeface(openXmlElement);
      value.Panose = GetPanose(openXmlElement);
      value.PitchFamily = GetPitchFamily(openXmlElement);
      value.CharacterSet = GetCharacterSet(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TextFontType? value)
    where OpenXmlElementType : TextFontType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTypeface(openXmlElement, value?.Typeface);
      SetPanose(openXmlElement, value?.Panose);
      SetPitchFamily(openXmlElement, value?.PitchFamily);
      SetCharacterSet(openXmlElement, value?.CharacterSet);
      return openXmlElement;
    }
    return default;
  }
}