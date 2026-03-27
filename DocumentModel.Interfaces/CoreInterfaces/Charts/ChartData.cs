
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents chart data.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata?view=office-pia"/>
public partial interface ChartData: InteropObject
{
  /// <summary>
  /// Gets the `Workbook` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.workbook?view=office-pia"/>
  public object Workbook { get; }
  /// <summary>
  /// Gets the `IsLinked` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.islinked?view=office-pia"/>
  public bool IsLinked { get; }
}

