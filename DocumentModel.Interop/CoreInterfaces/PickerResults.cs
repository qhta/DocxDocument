using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of `PickerResult` objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresults?view=office-pia"/>
public partial interface IPickerResults: IInteropCollection<PickerResult>
{


  #region methods

/// <summary>
  /// Adds a `PickerResult` to the collection.
  /// </summary>
  /// <param name="Id">The `Id` parameter.</param>
  /// <param name="DisplayName">The `DisplayName` parameter.</param>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="SIPId">The `SIPId` parameter.</param>
  /// <param name="ItemData">The `ItemData` parameter.</param>
  /// <param name="SubItems">The `SubItems` parameter.</param>
  /// <returns>The added picker result.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresults.add?view=office-pia"/>
  public PickerResult Add(string Id, string DisplayName, string Type, string SIPId, object ItemData, object SubItems);

  #endregion methods
}

