namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how to evenly distribute a collection of shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodistributecmd?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoDistributeCmd")]
public enum DistributeCmd
{
  /// <summary>
  /// Distribute horizontally.
  /// </summary>
  [OfficeInteropEnumValue("msoDistributeHorizontally")]
  Horizontally,
  /// <summary>
  /// Distribute vertically.
  /// </summary>
  [OfficeInteropEnumValue("msoDistributeVertically")]
  Vertically
}
