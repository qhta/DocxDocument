
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Answer Wizard in a Microsoft Office application.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard?view=office-pia"/>
public partial class AnswerWizard: InteropObject
{
  /// <summary>
  /// Gets the Answer Wizard files available to the active Office application.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard.files?view=office-pia"/>
  public AnswerWizardFiles Files { get; }


  #region methods

/// <summary>
  /// Clears the list of Answer Wizard files.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard.clearfilelist?view=office-pia"/>
  public void ClearFileList() { throw new NotImplementedException(); }
  /// <summary>
  /// Resets the Answer Wizard file list to the default set.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard.resetfilelist?view=office-pia"/>
  public void ResetFileList() { throw new NotImplementedException(); }

  #endregion methods
}

