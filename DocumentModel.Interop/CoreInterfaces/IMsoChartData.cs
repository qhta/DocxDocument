
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoChartData` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoChartData
{
  /// <summary>
  /// Gets the `Workbook` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.workbook?view=office-pia
  /// </remarks>
  public object Workbook { get; }
  /// <summary>
  /// Gets the `IsLinked` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.islinked?view=office-pia
  /// </remarks>
  public bool IsLinked { get; }
}
