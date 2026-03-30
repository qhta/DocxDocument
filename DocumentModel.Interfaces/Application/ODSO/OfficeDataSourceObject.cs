
namespace DocumentModel.Application;

/// <summary>
/// Represents the mail merge data source in a mail merge operation.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject?view=office-pia"/>
public partial interface OfficeDataSourceObject: IModelObject
{
  /// <summary>
  /// Gets or sets the `ConnectString` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.connectstring?view=office-pia"/>
  public string ConnectString { get; set; }
  /// <summary>
  /// Gets or sets the `Table` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.table?view=office-pia"/>
  public string Table { get; set; }
  /// <summary>
  /// Gets or sets the `DataSource` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.datasource?view=office-pia"/>
  public string DataSource { get; set; }
  /// <summary>
  /// Gets the `Columns` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.columns?view=office-pia"/>
  public object Columns { get; }
  /// <summary>
  /// Gets the `RowCount` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.rowcount?view=office-pia"/>
  public int RowCount { get; }
  /// <summary>
  /// Gets the `Filters` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.filters?view=office-pia"/>
  public object Filters { get; }
}

