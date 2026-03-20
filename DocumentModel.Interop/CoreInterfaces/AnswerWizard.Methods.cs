
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Answer Wizard in a Microsoft Office application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard?view=office-pia
/// </remarks>
public partial interface AnswerWizard
{
  /// <summary>
  /// Clears the list of Answer Wizard files.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard.clearfilelist?view=office-pia
  /// </remarks>
  public void ClearFileList();
  /// <summary>
  /// Resets the Answer Wizard file list to the default set.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard.resetfilelist?view=office-pia
  /// </remarks>
  public void ResetFileList();
}
