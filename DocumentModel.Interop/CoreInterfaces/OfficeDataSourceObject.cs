
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `OfficeDataSourceObject` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject?view=office-pia` for Office interop details.
/// </remarks>
public partial interface OfficeDataSourceObject
{
  /// <summary>
  /// Gets or sets the `ConnectString` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.connectstring?view=office-pia
  /// </remarks>
  public string ConnectString { get; set; }
  /// <summary>
  /// Gets or sets the `Table` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.table?view=office-pia
  /// </remarks>
  public string Table { get; set; }
  /// <summary>
  /// Gets or sets the `DataSource` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.datasource?view=office-pia
  /// </remarks>
  public string DataSource { get; set; }
  /// <summary>
  /// Gets the `Columns` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.columns?view=office-pia
  /// </remarks>
  public object Columns { get; }
  /// <summary>
  /// Gets the `RowCount` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.rowcount?view=office-pia
  /// </remarks>
  public int RowCount { get; }
  /// <summary>
  /// Gets the `Filters` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.filters?view=office-pia
  /// </remarks>
  public object Filters { get; }
}
