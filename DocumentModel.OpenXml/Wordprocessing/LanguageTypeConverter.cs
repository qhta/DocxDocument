using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the LanguageType Class.
/// </summary>
public static class LanguageTypeConverter
{
  /// <summary>
  ///   Latin Language
  /// </summary>
  public static String? GetVal(LanguageType? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(LanguageType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  /// <summary>
  ///   East Asian Language
  /// </summary>
  public static String? GetEastAsia(LanguageType? openXmlElement)
  {
    return openXmlElement?.EastAsia?.Value;
  }

  public static void SetEastAsia(LanguageType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EastAsia = new StringValue { Value = value };
      else
        openXmlElement.EastAsia = null;
  }

  /// <summary>
  ///   Complex Script Language
  /// </summary>
  public static String? GetBidi(LanguageType? openXmlElement)
  {
    return openXmlElement?.Bidi?.Value;
  }

  public static void SetBidi(LanguageType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Bidi = new StringValue { Value = value };
      else
        openXmlElement.Bidi = null;
  }

  public static DocumentModel.Wordprocessing.LanguageType? CreateModelElement(LanguageType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LanguageType();
      value.Val = GetVal(openXmlElement);
      value.EastAsia = GetEastAsia(openXmlElement);
      value.Bidi = GetBidi(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LanguageType? value)
    where OpenXmlElementType : LanguageType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetEastAsia(openXmlElement, value?.EastAsia);
      SetBidi(openXmlElement, value?.Bidi);
      return openXmlElement;
    }
    return default;
  }
}