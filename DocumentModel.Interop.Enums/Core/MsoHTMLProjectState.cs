
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the current state of an HTMLProject object.
/// </summary>
public enum MsoHTMLProjectState
{
  /// <summary>
  /// Document is locked. In a Microsoft Office host application or Microsoft Script Editor, indicates that the
  /// Refresh toolbar is displayed in the host application.
  /// </summary>
  msoHTMLProjectStateDocumentLocked = 1,
  /// <summary>
  /// Project is locked. In the Microsoft Script Editor, indicates that the Refresh toolbar is displayed.
  /// msoHTMLProjectStateDocumentProjectUnlocked3 Document is unlocked. In a Microsoft Office host application or
  /// Microsoft Script Editor, indicates that the Refresh toolbar is not displayed at all.
  /// </summary>
  msoHTMLProjectStateProjectLocked,
  /// <summary>
  /// Specifies the current state of an HTMLProject object.
  /// </summary>
  msoHTMLProjectStateDocumentProjectUnlocked
}
