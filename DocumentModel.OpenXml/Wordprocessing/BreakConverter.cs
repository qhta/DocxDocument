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
  
}
