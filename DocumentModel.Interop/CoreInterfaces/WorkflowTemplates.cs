using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WorkflowTemplates` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.workflowtemplates?view=office-pia
/// </remarks>
public partial interface WorkflowTemplates: InteropCollection<WorkflowTemplate>
{
}
