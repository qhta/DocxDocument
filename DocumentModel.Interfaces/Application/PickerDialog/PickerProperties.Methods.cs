using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of `PickerProperty` objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties?view=office-pia"/>
public partial interface IPickerProperties: IModelObject
{
  /// <summary>
  /// Adds a `PickerProperty` to the collection.
  /// </summary>
  /// <param name="Id">The `Id` parameter.</param>
  /// <param name="Value">The `Value` parameter.</param>
  /// <param name="Type">The `Type` parameter.</param>
  /// <returns>The added picker property.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties.add?view=office-pia"/>
  public IPickerProperty Add(string Id, string Value, IPickerField Type);
  /// <summary>
  /// Removes a `PickerProperty` from the collection.
  /// </summary>
  /// <param name="Id">The `Id` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties.remove?view=office-pia"/>
  public void Remove(string Id);
}

