namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of information to remove from a document.
/// </summary>
public enum WdRemoveDocInfoType
{
  /// <summary>
  /// Removes document comments.
  /// </summary>
  wdRDIComments = unchecked((int)1),
  /// <summary>
  /// Removes revision marks.
  /// </summary>
  wdRDIRevisions = unchecked((int)2),
  /// <summary>
  /// Removes document version information. wdRDIRemovePersonalInformation4 Removes personal information.
  /// </summary>
  wdRDIVersions = unchecked((int)3),
  /// <summary>
  /// Specifies the type of information to remove from a document.
  /// </summary>
  wdRDIRemovePersonalInformation = unchecked((int)4),
  /// <summary>
  /// Removes e-mail header information.
  /// </summary>
  wdRDIEmailHeader = unchecked((int)5),
  /// <summary>
  /// Removes routing slip information.
  /// </summary>
  wdRDIRoutingSlip = unchecked((int)6),
  /// <summary>
  /// Removes information stored when sending a document for review.
  /// </summary>
  wdRDISendForReview = unchecked((int)7),
  /// <summary>
  /// Removes document properties.
  /// </summary>
  wdRDIDocumentProperties = unchecked((int)8),
  /// <summary>
  /// Removes template information.
  /// </summary>
  wdRDITemplate = unchecked((int)9),
  /// <summary>
  /// Removes document workspace information.
  /// [System.Runtime.InteropServices.Guid("F52DEE7F-8295-3A23-9DB3-37609770B6B2")] public enum WdRemoveDocInfoType
  /// ﾉ Expand table
  /// </summary>
  wdRDIDocumentWorkspace = unchecked((int)10),
  /// <summary>
  /// Removes ink annotations. wdRDIDocumentServerProperties14 Removes document server properties.
  /// </summary>
  wdRDIInkAnnotations = unchecked((int)11),
  /// <summary>
  /// Specifies the type of information to remove from a document.
  /// </summary>
  wdRDIDocumentServerProperties = unchecked((int)14),
  /// <summary>
  /// Removes document management policy information.
  /// </summary>
  wdRDIDocumentManagementPolicy = unchecked((int)15),
  /// <summary>
  /// Removes content type information.
  /// </summary>
  wdRDIContentType = unchecked((int)16),
  /// <summary>
  /// Removes taskpane web extensions information.
  /// </summary>
  wdRDITaskpaneWebExtensions = unchecked((int)17),
  /// <summary>
  /// Removes all document information.
  /// </summary>
  wdRDIAll = unchecked((int)99)
}
