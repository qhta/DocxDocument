namespace DocumentModel;

/// <summary>
///   Defines WordprocessingDocumentType - type of WordprocessingDocument.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum WordprocessingDocumentType
{
  /// <summary>
  ///   Word Document (*.docx).
  /// </summary>
  Document,
  /// <summary>
  ///   Word Template (*.dotx).
  /// </summary>
  Template,
  /// <summary>
  ///   Word Macro-Enabled Document (*.docm).
  /// </summary>
  MacroEnabledDocument,
  /// <summary>
  ///   Word Macro-Enabled Template (*.dotm).
  /// </summary>
  MacroEnabledTemplate
}