namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of information to remove from a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdremovedocinfotype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdRemoveDocInfoType")]
public enum RemoveDocInfoType
{
  /// <summary>
  /// Removes document comments.
  /// </summary>
  [InteropEnumValue("wdRDIComments")]
  Comments = 1,
  /// <summary>
  /// Removes revision marks.
  /// </summary>
  [InteropEnumValue("wdRDIRevisions")]
  Revisions = 2,
  /// <summary>
  /// Removes document version information.
  /// </summary>
  [InteropEnumValue("wdRDIVersions")]
  Versions = 3,
  /// <summary>
  /// Removes personal information.
  /// </summary>
  [InteropEnumValue("wdRDIRemovePersonalInformation")]
  RemovePersonalInformation = 4,
  /// <summary>
  /// Removes e-mail header information.
  /// </summary>
  [InteropEnumValue("wdRDIEmailHeader")]
  EmailHeader = 5,
  /// <summary>
  /// Removes routing slip information.
  /// </summary>
  [InteropEnumValue("wdRDIRoutingSlip")]
  RoutingSlip = 6,
  /// <summary>
  /// Removes information stored when sending a document for review.
  /// </summary>
  [InteropEnumValue("wdRDISendForReview")]
  SendForReview = 7,
  /// <summary>
  /// Removes document properties.
  /// </summary>
  [InteropEnumValue("wdRDIDocumentProperties")]
  DocumentProperties = 8,
  /// <summary>
  /// Removes template information.
  /// </summary>
  [InteropEnumValue("wdRDITemplate")]
  Template = 9,
  /// <summary>
  /// Removes document workspace information.
  /// </summary>
  [InteropEnumValue("wdRDIDocumentWorkspace")]
  DocumentWorkspace = 10,
  /// <summary>
  /// Removes ink annotations.
  /// </summary>
  [InteropEnumValue("wdRDIInkAnnotations")]
  InkAnnotations = 11,
  /// <summary>
  /// Removes document server properties.
  /// </summary>
  [InteropEnumValue("wdRDIDocumentServerProperties")]
  DocumentServerProperties = 14,
  /// <summary>
  /// Removes document management policy information.
  /// </summary>
  [InteropEnumValue("wdRDIDocumentManagementPolicy")]
  DocumentManagementPolicy = 15,
  /// <summary>
  /// Removes content type information.
  /// </summary>
  [InteropEnumValue("wdRDIContentType")]
  ContentType = 16,
  /// <summary>
  /// Removes taskpane web extensions information.
  /// </summary>
  [InteropEnumValue("wdRDITaskpaneWebExtensions")]
  TaskpaneWebExtensions = 17,
  /// <summary>
  /// Removes all document information.
  /// </summary>
  [InteropEnumValue("wdRDIAll")]
  All = 99
}
