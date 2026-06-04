namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of task pane object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtaskpanes?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdTaskPanes")]
public enum WdTaskPanes
{
  /// <summary>
  /// Formatting pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneFormatting")]
  Formatting = 0,
  /// <summary>
  /// Reveal formatting codes pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneRevealFormatting")]
  RevealFormatting = 1,
  /// <summary>
  /// Mail merge pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneMailMerge")]
  MailMerge = 2,
  /// <summary>
  /// Translate pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneTranslate")]
  Translate = 3,
  /// <summary>
  /// Search pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneSearch")]
  Search = 4,
  /// <summary>
  /// XML structure pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneXMLStructure")]
  XMLStructure = 5,
  /// <summary>
  /// Document protection pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneDocumentProtection")]
  DocumentProtection = 6,
  /// <summary>
  /// Document actions pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneDocumentActions")]
  DocumentActions = 7,
  /// <summary>
  /// Shared workspace pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneSharedWorkspace")]
  SharedWorkspace = 8,
  /// <summary>
  /// Help pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneHelp")]
  Help = 9,
  /// <summary>
  /// Research pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneResearch")]
  Research = 10,
  /// <summary>
  /// Fax service pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneFaxService")]
  FaxService = 11,
  /// <summary>
  /// XML document pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneXMLDocument")]
  XMLDocument = 12,
  /// <summary>
  /// Document updates pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneDocumentUpdates")]
  DocumentUpdates = 13,
  /// <summary>
  /// Signature pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneSignature")]
  Signature = 14,
  /// <summary>
  /// Style inspector pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneStyleInspector")]
  StyleInspector = 15,
  /// <summary>
  /// Document management task pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneDocumentManagement")]
  DocumentManagement = 16,
  /// <summary>
  /// Apply styles pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneApplyStyles")]
  ApplyStyles = 17,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneNav")]
  Nav = 18,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneSelection")]
  Selection = 19,
  /// <summary>
  /// Proofing pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneProofing")]
  Proofing = 20,
  /// <summary>
  /// XML mapping pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneXMLMapping")]
  XMLMapping = 21,
  /// <summary>
  /// Revisions pane flex pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneRevPaneFlex")]
  RevPaneFlex = 22,
  /// <summary>
  /// Thesaurus pane.
  /// </summary>
  [WordInteropEnumValue("wdTaskPaneThesaurus")]
  Thesaurus = 23
}
