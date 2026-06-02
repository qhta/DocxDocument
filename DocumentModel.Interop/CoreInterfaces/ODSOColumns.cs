
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of fields in a data source.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns?view=office-pia"/>
public partial interface IODSOColumns: IInteropObject
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns.count?view=office-pia"/>
  public int Count { get; }


  #region methods

/// <summary>
  /// Returns a field from the collection.
  /// </summary>
  /// <param name="varIndex">The `varIndex` parameter.</param>
  /// <returns>The requested field object.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns.item?view=office-pia"/>
  public object Item(object varIndex);

  #endregion methods
}

