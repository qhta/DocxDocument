
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a custom task pane in the container application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customtaskpane?view=office-pia
/// </remarks>
public partial interface CustomTaskPane: _CustomTaskPane, _CustomTaskPaneEvents_Event
{
}
