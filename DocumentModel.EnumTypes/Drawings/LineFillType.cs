namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the type of fill Ifor a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinefilltype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum LineFillType
{
  /// <summary>
  /// Specifies a mixture of line fill types.
  /// </summary>
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

