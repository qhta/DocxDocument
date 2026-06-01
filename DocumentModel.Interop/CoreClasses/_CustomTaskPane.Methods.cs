using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a custom task pane in the container application.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane?view=office-pia"/>
public partial class _CustomTaskPane
{
  /// <summary>
  /// Deletes the active custom task pane.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
}

