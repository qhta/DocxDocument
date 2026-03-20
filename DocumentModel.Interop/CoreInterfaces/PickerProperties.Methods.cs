using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PickerProperties` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PickerProperties
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="Id">The `Id` parameter.</param>
  /// <param name="Value">The `Value` parameter.</param>
  /// <param name="Type">The `Type` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties.add?view=office-pia
  /// </remarks>
  public PickerProperty Add(string Id, string Value, MsoPickerField Type);
  /// <summary>
  /// Invokes `Remove`.
  /// </summary>
  /// <param name="Id">The `Id` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties.remove?view=office-pia
  /// </remarks>
  public void Remove(string Id);
}
