
namespace DocumentModel.Application;

/// <summary>
/// Represents a combo box control on a command bar.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcombobox?view=office-pia"/>
public partial interface ICommandBarComboBox: I_CommandBarComboBox, I_CommandBarComboBoxEvents_Event
{
}

