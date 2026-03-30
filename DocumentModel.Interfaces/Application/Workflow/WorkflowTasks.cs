using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `WorkflowTasks` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtasks?view=office-pia"/>
public partial interface WorkflowTasks: IModelCollection<WorkflowTask>
{
}

