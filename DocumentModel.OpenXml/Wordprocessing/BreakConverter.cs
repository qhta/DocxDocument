namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  /// Break Type
  /// </summary>
  public static DocumentModel.Wordprocessing.BreakKind? GetType(DocumentFormat.OpenXml.Wordprocessing.Break? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues, DocumentModel.Wordprocessing.BreakKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.Break? openXmlElement, DocumentModel.Wordprocessing.BreakKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues, DocumentModel.Wordprocessing.BreakKind>(value);
  }
  
  /// <summary>
  /// Restart Location For Text Wrapping Break
  /// </summary>
  public static DocumentModel.Wordprocessing.BreakTextRestartLocationKind? GetClear(DocumentFormat.OpenXml.Wordprocessing.Break? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues, DocumentModel.Wordprocessing.BreakTextRestartLocationKind>(openXmlElement?.Clear?.Value);
  }
  
  public static void SetClear(DocumentFormat.OpenXml.Wordprocessing.Break? openXmlElement, DocumentModel.Wordprocessing.BreakTextRestartLocationKind? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
