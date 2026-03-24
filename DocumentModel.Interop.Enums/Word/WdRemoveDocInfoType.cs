namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of information to remove from a document.
/// </summary>
public enum WdRemoveDocInfoType
{
  /// <summary>
  /// Removes document comments.
  /// </summary>
  Comments = 1,
  /// <summary>
  /// Removes revision marks.
  /// </summary>
  Revisions = 2,
  /// <summary>
  /// Removes document version information. wdRDIRemovePersonalInformation4 Removes personal information.
  /// </summary>
  Versions = 3,
  /// <summary>
  /// Specifies the type of information to remove from a document.
  /// </summary>
  RemovePersonalInformation = 4,
  /// <summary>
  /// Removes e-mail header information.
  /// </summary>
  EmailHeader = 5,
  /// <summary>
  /// Removes routing slip information.
  /// </summary>
  RoutingSlip = 6,
  /// <summary>
  /// Removes information stored when sending a document for review.
  /// </summary>
  SendForReview = 7,
  /// <summary>
  /// Removes document properties.
  /// </summary>
  DocumentProperties = 8,
  /// <summary>
  /// Removes template information.
  /// </summary>
  Template = 9,
  /// <summary>
  /// Removes document workspace information.
  /// [System.Runtime.InteropServices.Guid("F52DEE7F-8295-3A23-9DB3-37609770B6B2")] public enum WdRemoveDocInfoType
  /// ﾉ Expand table
  /// </summary>
  DocumentWorkspace = 10,
  /// <summary>
  /// Removes ink annotations. wdRDIDocumentServerProperties14 Removes document server properties.
  /// </summary>
  InkAnnotations = 11,
  /// <summary>
  /// Specifies the type of information to remove from a document.
  /// </summary>
  DocumentServerProperties = 14,
  /// <summary>
  /// Removes document management policy information.
  /// </summary>
  DocumentManagementPolicy = 15,
  /// <summary>
  /// Removes content type information.
  /// </summary>
  ContentType = 16,
  /// <summary>
  /// Removes taskpane web extensions information.
  /// </summary>
  TaskpaneWebExtensions = 17,
  /// <summary>
  /// Removes all document information.
  /// </summary>
  All = 99
}
