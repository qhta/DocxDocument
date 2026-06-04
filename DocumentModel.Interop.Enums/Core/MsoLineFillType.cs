namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of fill for a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinefilltype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoLineFillType")]
public enum LineFillType
{
  /// <summary>
  /// Specifies a mixture of line fill types.
  /// </summary>
  [InteropEnumValue("msoLineFillMixed")]
  Mixed = -2,
  /// <summary>
  /// No line fill.
  /// </summary>
  [InteropEnumValue("msoLineFillNone")]
  None = 0,
  /// <summary>
  /// Specifies a solid color line fill.
  /// </summary>
  [InteropEnumValue("msoLineFillSolid")]
  Solid = 1,
  /// <summary>
  /// Specifies a pattern line fill.
  /// </summary>
  [InteropEnumValue("msoLineFillPatterned")]
  Patterned = 2,
  /// <summary>
  /// Specifies a gradient line fill.
  /// </summary>
  [InteropEnumValue("msoLineFillGradient")]
  Gradient = 3,
  /// <summary>
  /// Specifies a textured line fill.
  /// </summary>
  [InteropEnumValue("msoLineFillTextured")]
  Textured = 4,
  /// <summary>
  /// Specifies the same fill as the background.
  /// </summary>
  [InteropEnumValue("msoLineFillBackground")]
  Background = 5,
  /// <summary>
  /// Specifies a picture line fill.
  /// </summary>
  [InteropEnumValue("msoLineFillPicture")]
  Picture = 6
}
