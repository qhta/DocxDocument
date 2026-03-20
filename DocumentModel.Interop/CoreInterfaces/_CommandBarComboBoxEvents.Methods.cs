
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcomboboxevents?view=office-pia
/// </remarks>
public partial interface _CommandBarComboBoxEvents
{
  /// <summary>
  /// Occurs when the end user changes the selection in a command bar combo box.
  /// </summary>
  /// <param name="Ctrl">The `Ctrl` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcomboboxevents.change?view=office-pia
  /// </remarks>
  public void Change(CommandBarComboBox Ctrl);
}
