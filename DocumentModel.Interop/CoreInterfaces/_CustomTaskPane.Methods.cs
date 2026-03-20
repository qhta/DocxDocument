using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a custom task pane in the container application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane?view=office-pia
/// </remarks>
public partial interface _CustomTaskPane
{
  /// <summary>
  /// Deletes the active custom task pane.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
