namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the StyleSet Class.
/// </summary>
public static class StyleSetConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetId(DXO2010W.StyleSet openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DXO2010W.StyleSet openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.OnOffKind? GetVal(DXO2010W.StyleSet openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement?.Val?.Value);
  }
  
  private static void SetVal(DXO2010W.StyleSet openXmlElement, DMW.OnOffKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(value);
  }
  
  public static DMW.StyleSet? CreateModelElement(DXO2010W.StyleSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.StyleSet();
      value.Id = GetId(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.StyleSet? value)
    where OpenXmlElementType: DXO2010W.StyleSet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
