namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of task pane object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtaskpanes?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTaskPanes")]
public enum WdTaskPanes
{
  /// <summary>
  /// Formatting pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneFormatting")]
  Formatting = 0,
  /// <summary>
  /// Reveal formatting codes pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneRevealFormatting")]
  RevealFormatting = 1,
  /// <summary>
  /// Mail merge pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneMailMerge")]
  MailMerge = 2,
  /// <summary>
  /// Translate pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneTranslate")]
  Translate = 3,
  /// <summary>
  /// Search pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneSearch")]
  Search = 4,
  /// <summary>
  /// XML structure pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneXMLStructure")]
  XMLStructure = 5,
  /// <summary>
  /// Document protection pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneDocumentProtection")]
  DocumentProtection = 6,
  /// <summary>
  /// Document actions pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneDocumentActions")]
  DocumentActions = 7,
  /// <summary>
  /// Shared workspace pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneSharedWorkspace")]
  SharedWorkspace = 8,
  /// <summary>
  /// Help pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneHelp")]
  Help = 9,
  /// <summary>
  /// Research pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneResearch")]
  Research = 10,
  /// <summary>
  /// Fax service pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneFaxService")]
  FaxService = 11,
  /// <summary>
  /// XML document pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneXMLDocument")]
  XMLDocument = 12,
  /// <summary>
  /// Document updates pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneDocumentUpdates")]
  DocumentUpdates = 13,
  /// <summary>
  /// Signature pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneSignature")]
  Signature = 14,
  /// <summary>
  /// Style inspector pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneStyleInspector")]
  StyleInspector = 15,
  /// <summary>
  /// Document management task pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneDocumentManagement")]
  DocumentManagement = 16,
  /// <summary>
  /// Apply styles pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneApplyStyles")]
  ApplyStyles = 17,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdTaskPaneNav")]
  Nav = 18,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdTaskPaneSelection")]
  Selection = 19,
  /// <summary>
  /// Proofing pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneProofing")]
  Proofing = 20,
  /// <summary>
  /// XML mapping pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneXMLMapping")]
  XMLMapping = 21,
  /// <summary>
  /// Revisions pane flex pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneRevPaneFlex")]
  RevPaneFlex = 22,
  /// <summary>
  /// Thesaurus pane.
  /// </summary>
  [InteropEnumValue("wdTaskPaneThesaurus")]
  Thesaurus = 23
}
