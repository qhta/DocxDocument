namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how to evenly distribute a collection of shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodistributecmd?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoDistributeCmd")]
public enum DistributeCmd
{
  /// <summary>
  /// Distribute horizontally.
  /// </summary>
  [InteropEnumValue("msoDistributeHorizontally")]
  Horizontally,
  /// <summary>
  /// Distribute vertically.
  /// </summary>
  [InteropEnumValue("msoDistributeVertically")]
  Vertically
}
