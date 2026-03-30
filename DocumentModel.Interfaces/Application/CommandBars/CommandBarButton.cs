
namespace DocumentModel.Application;

/// <summary>
/// Represents a button control on a command bar.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarbutton?view=office-pia"/>
public partial interface ICommandBarButton: I_CommandBarButton, I_CommandBarButtonEvents_Event
{
}

