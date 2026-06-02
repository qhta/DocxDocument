
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcomboboxevents?view=office-pia"/>
public partial interface _ICommandBarComboBoxEvents
{
  /// <summary>
  /// Occurs when the end user changes the selection in a command bar combo box.
  /// </summary>
  /// <param name="Ctrl">The `Ctrl` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcomboboxevents.change?view=office-pia"/>
  public void Change(CommandBarComboBox Ctrl);
}

