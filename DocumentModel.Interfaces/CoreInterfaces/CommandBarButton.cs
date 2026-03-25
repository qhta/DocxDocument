
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a button control on a command bar.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarbutton?view=office-pia"/>
public partial interface CommandBarButton: _CommandBarButton, _CommandBarButtonEvents_Event
{
}

