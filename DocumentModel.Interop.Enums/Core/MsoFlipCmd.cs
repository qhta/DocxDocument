namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether a shape should be flipped horizontally or vertically.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoflipcmd?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFlipCmd))]
public enum FlipCmd
{
  /// <summary>
  /// Flip horizontally.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFlipCmd.msoFlipHorizontal))]
  Horizontal,
  /// <summary>
  /// Flip vertically.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFlipCmd.msoFlipVertical))]
  Vertical
}
