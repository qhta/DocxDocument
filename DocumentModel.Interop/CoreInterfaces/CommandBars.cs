
namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of command bars in the container application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbars?view=office-pia
/// </remarks>
public partial interface CommandBars: _CommandBars, _CommandBarsEvents_Event
{
}
