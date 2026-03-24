
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the `WorkflowTemplate` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate?view=office-pia"/>
public partial interface WorkflowTemplate
{
  /// <summary>
  /// Invokes `Show`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.show?view=office-pia"/>
  public int Show();
}

