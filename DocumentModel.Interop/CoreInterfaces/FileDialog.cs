namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides file dialog box functionality similar to Office Open and Save dialogs.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialog?view=office-pia"/>
public interface IFileDialog
{


  #region methods

/// <summary>
  /// Displays the file dialog.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialog.show?view=office-pia"/>
  public int Show();
  /// <summary>
  /// Executes the action associated with the file dialog.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialog.execute?view=office-pia"/>
  public void Execute();

  #endregion methods
}

