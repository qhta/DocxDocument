namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of task pane object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtaskpanes?view=office-pia` for Office interop details.
/// </remarks>
public enum WdTaskPanes
{
  /// <summary>
  /// Formatting pane.
  /// </summary>
  Formatting = 0,
  /// <summary>
  /// Reveal formatting codes pane.
  /// </summary>
  RevealFormatting = 1,
  /// <summary>
  /// Mail merge pane.
  /// </summary>
  MailMerge = 2,
  /// <summary>
  /// Translate pane.
  /// </summary>
  Translate = 3,
  /// <summary>
  /// Search pane.
  /// </summary>
  Search = 4,
  /// <summary>
  /// XML structure pane.
  /// </summary>
  XMLStructure = 5,
  /// <summary>
  /// Document protection pane.
  /// </summary>
  DocumentProtection = 6,
  /// <summary>
  /// Document actions pane.
  /// </summary>
  DocumentActions = 7,
  /// <summary>
  /// Shared workspace pane.
  /// </summary>
  SharedWorkspace = 8,
  /// <summary>
  /// Help pane.
  /// </summary>
  Help = 9,
  /// <summary>
  /// Research pane.
  /// </summary>
  Research = 10,
  /// <summary>
  /// Fax service pane.
  /// </summary>
  FaxService = 11,
  /// <summary>
  /// XML document pane.
  /// </summary>
  XMLDocument = 12,
  /// <summary>
  /// Document updates pane.
  /// </summary>
  DocumentUpdates = 13,
  /// <summary>
  /// Signature pane.
  /// </summary>
  Signature = 14,
  /// <summary>
  /// Style inspector pane.
  /// </summary>
  StyleInspector = 15,
  /// <summary>
  /// Document management task pane.
  /// </summary>
  DocumentManagement = 16,
  /// <summary>
  /// Apply styles pane.
  /// </summary>
  ApplyStyles = 17,
  /// <summary>
  /// No description is available.
  /// </summary>
  Nav = 18,
  /// <summary>
  /// No description is available.
  /// </summary>
  Selection = 19,
  /// <summary>
  /// Proofing pane.
  /// </summary>
  Proofing = 20,
  /// <summary>
  /// XML mapping pane.
  /// </summary>
  XMLMapping = 21,
  /// <summary>
  /// Revisions pane flex pane.
  /// </summary>
  RevPaneFlex = 22,
  /// <summary>
  /// Thesaurus pane.
  /// </summary>
  Thesaurus = 23
}
