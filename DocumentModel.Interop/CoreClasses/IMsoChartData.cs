
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents chart data.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata?view=office-pia"/>
public partial class IMsoChartData
{
  /// <summary>
  /// Gets the `Workbook` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.workbook?view=office-pia"/>
  public object Workbook { get; }
  /// <summary>
  /// Gets the `IsLinked` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.islinked?view=office-pia"/>
  public bool IsLinked { get; }
}

