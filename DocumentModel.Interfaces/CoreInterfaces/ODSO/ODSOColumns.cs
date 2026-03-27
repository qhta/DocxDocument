
namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of fields in a data source.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns?view=office-pia"/>
public partial interface ODSOColumns: InteropObject
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns.count?view=office-pia"/>
  public int Count { get; }
}

