namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextFontType Class.
/// </summary>
public static class TextFontTypeConverter
{
  /// <summary>
  /// Text Typeface
  /// </summary>
  private static String? GetTypeface(DocumentFormat.OpenXml.Drawing.TextFontType openXmlElement)
  {
    return openXmlElement?.Typeface?.Value;
  }
  
  private static void SetTypeface(DocumentFormat.OpenXml.Drawing.TextFontType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Typeface = new StringValue { Value = value };
    else
      openXmlElement.Typeface = null;
  }
  
  /// <summary>
  /// Panose Setting
  /// </summary>
  private static Byte[]? GetPanose(DocumentFormat.OpenXml.Drawing.TextFontType openXmlElement)
  {
    if (openXmlElement.Panose?.Value != null)
      return Convert.FromHexString(openXmlElement.Panose.Value);
    return null;
  }
  
  private static void SetPanose(DocumentFormat.OpenXml.Drawing.TextFontType openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Panose = Convert.ToHexString(value);
    else
      openXmlElement.Panose = null;
  }
  
  /// <summary>
  /// Similar Font Family
  /// </summary>
  private static SByte? GetPitchFamily(DocumentFormat.OpenXml.Drawing.TextFontType openXmlElement)
  {
    return openXmlElement.PitchFamily?.Value;
  }
  
  private static void SetPitchFamily(DocumentFormat.OpenXml.Drawing.TextFontType openXmlElement, SByte? value)
  {
    openXmlElement.PitchFamily = value;
  }
  
  /// <summary>
  /// Similar Character Set
  /// </summary>
  private static SByte? GetCharacterSet(DocumentFormat.OpenXml.Drawing.TextFontType openXmlElement)
  {
    return openXmlElement.CharacterSet?.Value;
  }
  
  private static void SetCharacterSet(DocumentFormat.OpenXml.Drawing.TextFontType openXmlElement, SByte? value)
  {
    openXmlElement.CharacterSet = value;
  }
  
  public static DocumentModel.Drawings.TextFontType? CreateModelElement(DocumentFormat.OpenXml.Drawing.TextFontType? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.TextFontType, new()
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
