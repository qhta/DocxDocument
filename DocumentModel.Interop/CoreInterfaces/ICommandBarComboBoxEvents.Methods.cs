
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ICommandBarComboBoxEvents` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarcomboboxevents?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ICommandBarComboBoxEvents
{
  /// <summary>
  /// Invokes `Change`.
  /// </summary>
  /// <param name="Ctrl">The `Ctrl` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarcomboboxevents.change?view=office-pia
  /// </remarks>
  public void Change(CommandBarComboBox Ctrl);
}
