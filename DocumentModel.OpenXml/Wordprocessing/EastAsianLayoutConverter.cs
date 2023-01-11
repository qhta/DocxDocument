namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the EastAsianLayout Class.
/// </summary>
public static class EastAsianLayoutConverter
{
  /// <summary>
  /// East Asian Typography Run ID
  /// </summary>
  public static Int32? GetId(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Two Lines in One
  /// </summary>
  public static Boolean? GetCombine(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement)
  {
    return openXmlElement?.Combine?.Value;
  }
  
  public static void SetCombine(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Combine = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Combine = null;
  }
  
  /// <summary>
  /// Display Brackets Around Two Lines in One
  /// </summary>
  public static DocumentModel.Wordprocessing.CombineBracketKind? GetCombineBrackets(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues, DocumentModel.Wordprocessing.CombineBracketKind>(openXmlElement?.CombineBrackets?.Value);
  }
  
  public static void SetCombineBrackets(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement, DocumentModel.Wordprocessing.CombineBracketKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CombineBrackets = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues, DocumentModel.Wordprocessing.CombineBracketKind>(value);
  }
  
  /// <summary>
  /// Horizontal in Vertical (Rotate Text)
  /// </summary>
  public static Boolean? GetVertical(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement)
  {
    return openXmlElement?.Vertical?.Value;
  }
  
  public static void SetVertical(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Vertical = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Vertical = null;
  }
  
  /// <summary>
  /// Compress Rotated Text to Line Height
  /// </summary>
  public static Boolean? GetVerticalCompress(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement)
  {
    return openXmlElement?.VerticalCompress?.Value;
  }
  
  public static void SetVerticalCompress(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.VerticalCompress = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.VerticalCompress = null;
  }
  
  public static DocumentModel.Wordprocessing.EastAsianLayout? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
