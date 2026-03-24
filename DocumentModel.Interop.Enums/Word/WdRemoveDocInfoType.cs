namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of information to remove from a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdremovedocinfotype?view=office-pia` for Office interop details.
/// </remarks>
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
  /// Removes document version information.
  /// </summary>
  Versions = 3,
  /// <summary>
  /// Removes personal information.
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
  /// </summary>
  DocumentWorkspace = 10,
  /// <summary>
  /// Specifies the type of information to remove from a document.
  /// </summary>
  InkAnnotations = 11,
  /// <summary>
  /// Specifies the type of information to remove from a document.
  /// </summary>
  DocumentServerProperties = 14,
  /// <summary>
  /// Specifies the type of information to remove from a document.
  /// </summary>
  DocumentManagementPolicy = 15,
  /// <summary>
  /// Specifies the type of information to remove from a document.
  /// </summary>
  ContentType = 16,
  /// <summary>
  /// Specifies the type of information to remove from a document.
  /// </summary>
  TaskpaneWebExtensions = 17,
  /// <summary>
  /// Specifies the type of information to remove from a document.
  /// </summary>
  All = 99
}
