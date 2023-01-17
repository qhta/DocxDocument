namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the EastAsianLayout Class.
/// </summary>
public static class EastAsianLayoutConverter
{
  /// <summary>
  /// East Asian Typography Run ID
  /// </summary>
  private static Int32? GetId(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout openXmlElement, Int32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Two Lines in One
  /// </summary>
  private static Boolean? GetCombine(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout openXmlElement)
  {
    return openXmlElement?.Combine?.Value;
  }
  
  private static void SetCombine(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Combine = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Combine = null;
  }
  
  /// <summary>
  /// Display Brackets Around Two Lines in One
  /// </summary>
  private static DocumentModel.Wordprocessing.CombineBracketKind? GetCombineBrackets(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues, DocumentModel.Wordprocessing.CombineBracketKind>(openXmlElement?.CombineBrackets?.Value);
  }
  
  private static void SetCombineBrackets(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout openXmlElement, DocumentModel.Wordprocessing.CombineBracketKind? value)
  {
    openXmlElement.CombineBrackets = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues, DocumentModel.Wordprocessing.CombineBracketKind>(value);
  }
  
  /// <summary>
  /// Horizontal in Vertical (Rotate Text)
  /// </summary>
  private static Boolean? GetVertical(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout openXmlElement)
  {
    return openXmlElement?.Vertical?.Value;
  }
  
  private static void SetVertical(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Vertical = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Vertical = null;
  }
  
  /// <summary>
  /// Compress Rotated Text to Line Height
  /// </summary>
  private static Boolean? GetVerticalCompress(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout openXmlElement)
  {
    return openXmlElement?.VerticalCompress?.Value;
  }
  
  private static void SetVerticalCompress(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout openXmlElement, Boolean? value)
  {
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
