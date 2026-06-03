using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of `PickerResult` objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresults?view=office-pia"/>
public partial class PickerResults: InteropCollection<PickerResult>
{


  #region methods

/// <summary>
  /// Adds a `PickerResult` to the collection.
  /// </summary>
  /// <param name="id">The `Id` parameter.</param>
  /// <param name="displayName">The `DisplayName` parameter.</param>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="sIPId">The `SIPId` parameter.</param>
  /// <param name="itemData">The `ItemData` parameter.</param>
  /// <param name="subItems">The `SubItems` parameter.</param>
  /// <returns>The added picker result.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresults.add?view=office-pia"/>
  public PickerResult Add(string id, string displayName, string type, string sIPId, object itemData, object subItems) { throw new NotImplementedException(); }

  #endregion methods
}

