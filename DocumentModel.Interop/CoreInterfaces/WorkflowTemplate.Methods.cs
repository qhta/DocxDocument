
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WorkflowTemplate` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate?view=office-pia
/// </remarks>
public partial interface WorkflowTemplate
{
  /// <summary>
  /// Invokes `Show`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.show?view=office-pia
  /// </remarks>
  public int Show();
}
