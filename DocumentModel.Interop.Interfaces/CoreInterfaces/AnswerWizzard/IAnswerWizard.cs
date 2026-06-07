
namespace DocumentModel.Interop.Core;
/// <summary>
/// The Microsoft Word Answer Wizard was a natural-language search feature in older versions of Microsoft Office
/// (such as Office 95 through Office 2003). It allowed users to type help questions in plain English
/// (e.g., "How do I print an envelope?") instead of browsing rigid help menus, eventually evolving into the modern "Tell Me" box.
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
