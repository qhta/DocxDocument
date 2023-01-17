namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  /// Break Type
  /// </summary>
  private static DocumentModel.Wordprocessing.BreakKind? GetType(DocumentFormat.OpenXml.Wordprocessing.Break openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues, DocumentModel.Wordprocessing.BreakKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Wordprocessing.Break openXmlElement, DocumentModel.Wordprocessing.BreakKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues, DocumentModel.Wordprocessing.BreakKind>(value);
  }
  
  /// <summary>
  /// Restart Location For Text Wrapping Break
  /// </summary>
  private static DocumentModel.Wordprocessing.BreakTextRestartLocationKind? GetClear(DocumentFormat.OpenXml.Wordprocessing.Break openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues, DocumentModel.Wordprocessing.BreakTextRestartLocationKind>(openXmlElement?.Clear?.Value);
  }
  
  private static void SetClear(DocumentFormat.OpenXml.Wordprocessing.Break openXmlElement, DocumentModel.Wordprocessing.BreakTextRestartLocationKind? value)
  {
    openXmlElement.Clear = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues, DocumentModel.Wordprocessing.BreakTextRestartLocationKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.Break? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Break();
      value.Type = GetType(openXmlElement);
      value.Clear = GetClear(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Break? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Break, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetClear(openXmlElement, value?.Clear);
      return openXmlElement;
    }
    return default;
  }
}
