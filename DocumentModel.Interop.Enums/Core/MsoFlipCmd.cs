namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether a shape should be flipped horizontally or vertically.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoflipcmd?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoFlipCmd")]
public enum FlipCmd
{
  /// <summary>
  /// Flip horizontally.
  /// </summary>
  [OfficeInteropEnumValue("msoFlipHorizontal")]
  Horizontal,
  /// <summary>
  /// Flip vertically.
  /// </summary>
  [OfficeInteropEnumValue("msoFlipVertical")]
  Vertical
}
