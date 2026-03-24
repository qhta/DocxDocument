namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of fill for a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinefilltype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoLineFillType
{
  /// <summary>
  /// Specifies the type of fill for a line.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// No line fill.
  /// </summary>
  None = 0,
  /// <summary>
  /// Specifies a solid color line fill.
  /// </summary>
  Solid = 1,
  /// <summary>
  /// Specifies a pattern line fill.
  /// </summary>
  Patterned = 2,
  /// <summary>
  /// Specifies a gradient line fill.
  /// </summary>
  Gradient = 3,
  /// <summary>
  /// Specifies a textured line fill.
  /// </summary>
  Textured = 4,
  /// <summary>
  /// Specifies the same fill as the background.
  /// </summary>
  Background = 5,
  /// <summary>
  /// Specifies a picture line fill.
  /// </summary>
  Picture = 6
}
