
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Answer Wizard in a Microsoft Office application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard?view=office-pia"/>
public interface IAnswerWizard: IInteropObject
{
  /// <summary>
  /// Gets the Answer Wizard files available to the active Office application.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard.files?view=office-pia"/>
  public IAnswerWizardFiles Files { get; }


  #region methods

/// <summary>
  /// Clears the list of Answer Wizard files.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard.clearfilelist?view=office-pia"/>
  public void ClearFileList();
  /// <summary>
  /// Resets the Answer Wizard file list to the default set.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard.resetfilelist?view=office-pia"/>
  public void ResetFileList();

  #endregion methods
}

