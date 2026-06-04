namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of information to remove from a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdremovedocinfotype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType))]
public enum RemoveDocInfoType
{
  /// <summary>
  /// Removes document comments.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIComments))]
  Comments = 1,
  /// <summary>
  /// Removes revision marks.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIRevisions))]
  Revisions = 2,
  /// <summary>
  /// Removes document version information.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIVersions))]
  Versions = 3,
  /// <summary>
  /// Removes personal information.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIRemovePersonalInformation))]
  RemovePersonalInformation = 4,
  /// <summary>
  /// Removes e-mail header information.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIEmailHeader))]
  EmailHeader = 5,
  /// <summary>
  /// Removes routing slip information.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIRoutingSlip))]
  RoutingSlip = 6,
  /// <summary>
  /// Removes information stored when sending a document for review.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDISendForReview))]
  SendForReview = 7,
  /// <summary>
  /// Removes document properties.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIDocumentProperties))]
  DocumentProperties = 8,
  /// <summary>
  /// Removes template information.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDITemplate))]
  Template = 9,
  /// <summary>
  /// Removes document workspace information.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIDocumentWorkspace))]
  DocumentWorkspace = 10,
  /// <summary>
  /// Removes ink annotations.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIInkAnnotations))]
  InkAnnotations = 11,
  /// <summary>
  /// Removes document server properties.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIDocumentServerProperties))]
  DocumentServerProperties = 14,
  /// <summary>
  /// Removes document management policy information.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIDocumentManagementPolicy))]
  DocumentManagementPolicy = 15,
  /// <summary>
  /// Removes content type information.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIContentType))]
  ContentType = 16,
  /// <summary>
  /// Removes taskpane web extensions information.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDITaskpaneWebExtensions))]
  TaskpaneWebExtensions = 17,
  /// <summary>
  /// Removes all document information.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRemoveDocInfoType.wdRDIAll))]
  All = 99
}
