
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the current state of an HTMLProject object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohtmlprojectstate?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoHTMLProjectState")]
public enum HTMLProjectState
{
  /// <summary>
  /// Document is locked. In a Microsoft Office host application or Microsoft Script Editor, indicates that the
  /// Refresh toolbar is displayed in the host application.
  /// </summary>
  [OfficeInteropEnumValue("msoHTMLProjectStateDocumentLocked")]
  DocumentLocked = 1,
  /// <summary>
  /// Project is locked. In the Microsoft Script Editor, indicates that the Refresh toolbar is displayed.
  /// </summary>
  [OfficeInteropEnumValue("msoHTMLProjectStateProjectLocked")]
  ProjectLocked,
  /// <summary>
  /// Document is unlocked. In a Microsoft Office host application or Microsoft Script Editor, indicates that the
  /// Refresh toolbar is not displayed at all.
  /// </summary>
  [OfficeInteropEnumValue("msoHTMLProjectStateDocumentProjectUnlocked")]
  DocumentProjectUnlocked
}
