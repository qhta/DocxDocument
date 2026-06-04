namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of task pane object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtaskpanes?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTaskPanes))]
public enum WdTaskPanes
{
  /// <summary>
  /// Formatting pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneFormatting))]
  Formatting = 0,
  /// <summary>
  /// Reveal formatting codes pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneRevealFormatting))]
  RevealFormatting = 1,
  /// <summary>
  /// Mail merge pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneMailMerge))]
  MailMerge = 2,
  /// <summary>
  /// Translate pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneTranslate))]
  Translate = 3,
  /// <summary>
  /// Search pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneSearch))]
  Search = 4,
  /// <summary>
  /// XML structure pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneXMLStructure))]
  XMLStructure = 5,
  /// <summary>
  /// Document protection pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneDocumentProtection))]
  DocumentProtection = 6,
  /// <summary>
  /// Document actions pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneDocumentActions))]
  DocumentActions = 7,
  /// <summary>
  /// Shared workspace pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneSharedWorkspace))]
  SharedWorkspace = 8,
  /// <summary>
  /// Help pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneHelp))]
  Help = 9,
  /// <summary>
  /// Research pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneResearch))]
  Research = 10,
  /// <summary>
  /// Fax service pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneFaxService))]
  FaxService = 11,
  /// <summary>
  /// XML document pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneXMLDocument))]
  XMLDocument = 12,
  /// <summary>
  /// Document updates pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneDocumentUpdates))]
  DocumentUpdates = 13,
  /// <summary>
  /// Signature pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneSignature))]
  Signature = 14,
  /// <summary>
  /// Style inspector pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneStyleInspector))]
  StyleInspector = 15,
  /// <summary>
  /// Document management task pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneDocumentManagement))]
  DocumentManagement = 16,
  /// <summary>
  /// Apply styles pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneApplyStyles))]
  ApplyStyles = 17,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneNav))]
  Nav = 18,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneSelection))]
  Selection = 19,
  /// <summary>
  /// Proofing pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneProofing))]
  Proofing = 20,
  /// <summary>
  /// XML mapping pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneXMLMapping))]
  XMLMapping = 21,
  /// <summary>
  /// Revisions pane flex pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneRevPaneFlex))]
  RevPaneFlex = 22,
  /// <summary>
  /// Thesaurus pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTaskPanes.wdTaskPaneThesaurus))]
  Thesaurus = 23
}
