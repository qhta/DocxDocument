namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LanguageType Class.
/// </summary>
public static class LanguageTypeConverter
{
  /// <summary>
  /// Latin Language
  /// </summary>
  private static String? GetVal(DXW.LanguageType openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DXW.LanguageType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// East Asian Language
  /// </summary>
  private static String? GetEastAsia(DXW.LanguageType openXmlElement)
  {
    return openXmlElement?.EastAsia?.Value;
  }
  
  private static void SetEastAsia(DXW.LanguageType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EastAsia = new StringValue { Value = value };
    else
      openXmlElement.EastAsia = null;
  }
  
  /// <summary>
  /// Complex Script Language
  /// </summary>
  private static String? GetBidi(DXW.LanguageType openXmlElement)
  {
    return openXmlElement?.Bidi?.Value;
  }
  
  private static void SetBidi(DXW.LanguageType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Bidi = new StringValue { Value = value };
    else
      openXmlElement.Bidi = null;
  }
  
  public static DMW.LanguageType? CreateModelElement(DXW.LanguageType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LanguageType();
      value.Val = GetVal(openXmlElement);
      value.EastAsia = GetEastAsia(openXmlElement);
      value.Bidi = GetBidi(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.LanguageType? value)
    where OpenXmlElementType: DXW.LanguageType, new()
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
