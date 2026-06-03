using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of `PickerProperty` objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties?view=office-pia"/>
public partial class PickerProperties: InteropCollection<PickerProperty>
{


  #region methods

/// <summary>
  /// Adds a `PickerProperty` to the collection.
  /// </summary>
  /// <param name="id">The `Id` parameter.</param>
  /// <param name="value">The `Value` parameter.</param>
  /// <param name="type">The `Type` parameter.</param>
  /// <returns>The added picker property.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties.add?view=office-pia"/>
  public PickerProperty Add(string id, string value, MsoPickerField type) { throw new NotImplementedException(); }
  /// <summary>
  /// Removes a `PickerProperty` from the collection.
  /// </summary>
  /// <param name="id">The `Id` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties.remove?view=office-pia"/>
  public void Remove(string id) { throw new NotImplementedException(); }

  #endregion methods
}

