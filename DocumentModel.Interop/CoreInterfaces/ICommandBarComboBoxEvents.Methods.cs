
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarcomboboxevents?view=office-pia
/// </remarks>
public partial interface ICommandBarComboBoxEvents
{
  /// <summary>
  /// Handles the change event for a command bar combo box.
  /// </summary>
  /// <param name="Ctrl">The `Ctrl` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarcomboboxevents.change?view=office-pia
  /// </remarks>
  public void Change(CommandBarComboBox Ctrl);
}
