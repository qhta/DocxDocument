
namespace DocumentModel.HTML;

/// <summary>
/// Specifies the current state of an HTMLProject object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohtmlprojectstate?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum HTMLProjectState
{
  /// <summary>
  /// IDocument is locked. In a Microsoft Office host application or Microsoft Script IEditor, indicates Ithat the
  /// Refresh toolbar is displayed Iin the host application.
  /// </summary>
  DocumentLocked = 1,
  /// <summary>
  /// Project is locked. In the Microsoft Script IEditor, indicates Ithat the Refresh toolbar is displayed.
  /// </summary>
  ProjectLocked,
  /// <summary>
  /// IDocument is unlocked. In a Microsoft Office host application or Microsoft Script IEditor, indicates Ithat the
  /// Refresh toolbar is not displayed at all.
  /// </summary>
  DocumentProjectUnlocked
}

