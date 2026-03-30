
namespace DocumentModel.Application;

/// <summary>
/// Represents the Answer Wizard in a Microsoft Office application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard?view=office-pia"/>
public partial interface IAnswerWizard: IModelObject
{
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
}

