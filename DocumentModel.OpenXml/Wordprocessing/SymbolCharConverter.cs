namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Symbol Character.
/// </summary>
public static class SymbolCharConverter
{
  /// <summary>
  /// Symbol Character Font
  /// </summary>
  private static String? GetFont(DocumentFormat.OpenXml.Wordprocessing.SymbolChar openXmlElement)
  {
    return openXmlElement?.Font?.Value;
  }
  
  private static void SetFont(DocumentFormat.OpenXml.Wordprocessing.SymbolChar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Font = new StringValue { Value = value };
    else
      openXmlElement.Font = null;
  }
  
  /// <summary>
  /// Symbol Character Code
  /// </summary>
  private static UInt16? GetChar(DocumentFormat.OpenXml.Wordprocessing.SymbolChar openXmlElement)
  {
    if (openXmlElement.Char?.Value != null)
      return UInt16.Parse(openXmlElement.Char.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetChar(DocumentFormat.OpenXml.Wordprocessing.SymbolChar openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.Char = ((UInt16)value).ToString("X4");
      else
        openXmlElement.Char = null;
  }
  
  public static DocumentModel.Wordprocessing.SymbolChar? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SymbolChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SymbolChar();
      value.Font = GetFont(openXmlElement);
      value.Char = GetChar(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SymbolChar? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SymbolChar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFont(openXmlElement, value?.Font);
      SetChar(openXmlElement, value?.Char);
      return openXmlElement;
    }
    return default;
  }
}
