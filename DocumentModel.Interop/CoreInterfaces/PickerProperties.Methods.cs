using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of `PickerProperty` objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties?view=office-pia
/// </remarks>
public partial interface PickerProperties
{
  /// <summary>
  /// Adds a `PickerProperty` to the collection.
  /// </summary>
  /// <param name="Id">The `Id` parameter.</param>
  /// <param name="Value">The `Value` parameter.</param>
  /// <param name="Type">The `Type` parameter.</param>
  /// <returns>The added picker property.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties.add?view=office-pia
  /// </remarks>
  public PickerProperty Add(string Id, string Value, MsoPickerField Type);
  /// <summary>
  /// Removes a `PickerProperty` from the collection.
  /// </summary>
  /// <param name="Id">The `Id` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties.remove?view=office-pia
  /// </remarks>
  public void Remove(string Id);
}
