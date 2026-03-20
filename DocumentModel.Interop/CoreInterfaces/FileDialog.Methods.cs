using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides file dialog box functionality similar to Office Open and Save dialogs.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialog?view=office-pia
/// </remarks>
public partial interface FileDialog
{
  /// <summary>
  /// Displays the file dialog.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialog.show?view=office-pia
  /// </remarks>
  public int Show();
  /// <summary>
  /// Executes the action associated with the file dialog.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialog.execute?view=office-pia
  /// </remarks>
  public void Execute();
}
