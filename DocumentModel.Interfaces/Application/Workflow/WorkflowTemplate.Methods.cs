
namespace DocumentModel.Application;

/// <summary>
/// Represents the `WorkflowTemplate` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate?view=office-pia"/>
public partial interface IWorkflowTemplate: IModelObject
{
  /// <summary>
  /// Invokes `Show`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplate.show?view=office-pia"/>
  public int Show();
}

