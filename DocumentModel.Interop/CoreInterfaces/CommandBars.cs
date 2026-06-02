
namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of command bars in the container application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbars?view=office-pia"/>
public partial interface ICommandBars: _CommandBars, _CommandBarsEvents_Event
{
}

