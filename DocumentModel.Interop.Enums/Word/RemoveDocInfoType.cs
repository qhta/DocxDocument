namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of information to remove from a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdremovedocinfotype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdRemoveDocInfoType")]
public enum RemoveDocInfoType
{
  /// <summary>
  /// Removes document comments.
  /// </summary>
  [WordInteropEnumValue("wdRDIComments")]
  Comments = 1,
  /// <summary>
  /// Removes revision marks.
  /// </summary>
  [WordInteropEnumValue("wdRDIRevisions")]
  Revisions = 2,
  /// <summary>
  /// Removes document version information.
  /// </summary>
  [WordInteropEnumValue("wdRDIVersions")]
  Versions = 3,
  /// <summary>
  /// Removes personal information.
  /// </summary>
  [WordInteropEnumValue("wdRDIRemovePersonalInformation")]
  RemovePersonalInformation = 4,
  /// <summary>
  /// Removes e-mail header information.
  /// </summary>
  [WordInteropEnumValue("wdRDIEmailHeader")]
  EmailHeader = 5,
  /// <summary>
  /// Removes routing slip information.
  /// </summary>
  [WordInteropEnumValue("wdRDIRoutingSlip")]
  RoutingSlip = 6,
  /// <summary>
  /// Removes information stored when sending a document for review.
  /// </summary>
  [WordInteropEnumValue("wdRDISendForReview")]
  SendForReview = 7,
  /// <summary>
  /// Removes document properties.
  /// </summary>
  [WordInteropEnumValue("wdRDIDocumentProperties")]
  DocumentProperties = 8,
  /// <summary>
  /// Removes template information.
  /// </summary>
  [WordInteropEnumValue("wdRDITemplate")]
  Template = 9,
  /// <summary>
  /// Removes document workspace information.
  /// </summary>
  [WordInteropEnumValue("wdRDIDocumentWorkspace")]
  DocumentWorkspace = 10,
  /// <summary>
  /// Removes ink annotations.
  /// </summary>
  [WordInteropEnumValue("wdRDIInkAnnotations")]
  InkAnnotations = 11,
  /// <summary>
  /// Removes document server properties.
  /// </summary>
  [WordInteropEnumValue("wdRDIDocumentServerProperties")]
  DocumentServerProperties = 14,
  /// <summary>
  /// Removes document management policy information.
  /// </summary>
  [WordInteropEnumValue("wdRDIDocumentManagementPolicy")]
  DocumentManagementPolicy = 15,
  /// <summary>
  /// Removes content type information.
  /// </summary>
  [WordInteropEnumValue("wdRDIContentType")]
  ContentType = 16,
  /// <summary>
  /// Removes taskpane web extensions information.
  /// </summary>
  [WordInteropEnumValue("wdRDITaskpaneWebExtensions")]
  TaskpaneWebExtensions = 17,
  /// <summary>
  /// Removes all document information.
  /// </summary>
  [WordInteropEnumValue("wdRDIAll")]
  All = 99
}
