using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of `PickerProperty` objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties?view=office-pia"/>
public interface IPickerProperties: IInteropCollection<IPickerProperty>
{


  #region methods

/// <summary>
  /// Adds a `PickerProperty` to the collection.
  /// </summary>
  /// <param name="id">The `Id` parameter.</param>
  /// <param name="value">The `Value` parameter.</param>
  /// <param name="type">The `Type` parameter.</param>
  /// <returns>The added picker property.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties.add?view=office-pia"/>
  public IPickerProperty Add(string id, string value, IPickerField type);
  /// <summary>
  /// Removes a `PickerProperty` from the collection.
  /// </summary>
  /// <param name="id">The `Id` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties.remove?view=office-pia"/>
  public void Remove(string id);

  #endregion methods
}

