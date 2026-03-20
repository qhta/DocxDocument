using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WorkflowTask` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask?view=office-pia
/// </remarks>
public partial interface WorkflowTask
{
  /// <summary>
  /// Invokes `Show`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.show?view=office-pia
  /// </remarks>
  public int Show();
}
