namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether a shape should be flipped horizontally or vertically.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoflipcmd?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoFlipCmd
{
  /// <summary>
  /// Flip horizontally.
  /// </summary>
  Horizontal,
  /// <summary>
  /// Flip vertically.
  /// </summary>
  Vertical
}
