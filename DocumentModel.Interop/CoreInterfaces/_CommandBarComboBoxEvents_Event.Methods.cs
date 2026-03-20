
namespace DocumentModel.Interop.Core;


/// <summary>
/// Events interface for CommandBarComboBox object events.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcomboboxevents_event?view=office-pia
/// </remarks>
public partial interface _CommandBarComboBoxEvents_Event
{
  /// <summary>
  /// Occurs when the end user changes the selection in a command bar combo box.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcomboboxevents_event.change?view=office-pia
  /// </remarks>
  public event _CommandBarComboBoxEvents_ChangeEventHandler Change;
}
