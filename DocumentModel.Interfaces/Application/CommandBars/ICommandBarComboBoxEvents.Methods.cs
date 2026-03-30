
namespace DocumentModel.Application;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarcomboboxevents?view=office-pia"/>
public partial interface ICommandBarComboBoxEvents: IModelObject
{
  /// <summary>
  /// Handles the change event for a command bar combo box.
  /// </summary>
  /// <param name="Ctrl">The `Ctrl` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarcomboboxevents.change?view=office-pia"/>
  public void Change(ICommandBarComboBox Ctrl);
}

