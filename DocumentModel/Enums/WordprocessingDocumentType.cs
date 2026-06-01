namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines WordprocessingDocumentType - type of WordprocessingDocument.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum WordprocessingDocumentType
{
  /// <summary>
  ///   Word IDocument (*.docx).
  /// </summary>
  IDocument,

  /// <summary>
  ///   Word ITemplate (*.dotx).
  /// </summary>
  ITemplate,

  /// <summary>
  ///   Word Macro-Enabled IDocument (*.docm).
  /// </summary>
  MacroEnabledDocument,

  /// <summary>
  ///   Word Macro-Enabled ITemplate (*.dotm).
  /// </summary>
  MacroEnabledTemplate
}
