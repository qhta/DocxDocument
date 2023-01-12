namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CheckBoxSymbolType Class.
/// </summary>
public static class CheckBoxSymbolTypeConverter
{
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetFont(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement)
  {
    return openXmlElement?.Font?.Value;
  }
  
  public static void SetFont(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Font = new StringValue { Value = value };
      else
        openXmlElement.Font = null;
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetVal(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return Convert.FromHexString(openXmlElement.Val.Value);
    return null;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Val = Convert.ToHexString(value);
      else
        openXmlElement.Val = null;
    }
  }
  
  public static DocumentModel.Wordprocessing.CheckBoxSymbolType? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CheckBoxSymbolType();
      value.Font = GetFont(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CheckBoxSymbolType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFont(openXmlElement, value?.Font);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
