using System;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `WorkflowTask` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask?view=office-pia"/>
public partial interface IWorkflowTask: IModelObject
{
  /// <summary>
  /// Invokes `Show`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtask.show?view=office-pia"/>
  public int Show();
}

