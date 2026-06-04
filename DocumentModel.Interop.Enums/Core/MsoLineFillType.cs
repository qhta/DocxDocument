namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of fill for a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinefilltype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoLineFillType")]
public enum LineFillType
{
  /// <summary>
  /// Specifies a mixture of line fill types.
  /// </summary>
  [OfficeInteropEnumValue("msoLineFillMixed")]
  Mixed = -2,
  /// <summary>
  /// No line fill.
  /// </summary>
  [OfficeInteropEnumValue("msoLineFillNone")]
  None = 0,
  /// <summary>
  /// Specifies a solid color line fill.
  /// </summary>
  [OfficeInteropEnumValue("msoLineFillSolid")]
  Solid = 1,
  /// <summary>
  /// Specifies a pattern line fill.
  /// </summary>
  [OfficeInteropEnumValue("msoLineFillPatterned")]
  Patterned = 2,
  /// <summary>
  /// Specifies a gradient line fill.
  /// </summary>
  [OfficeInteropEnumValue("msoLineFillGradient")]
  Gradient = 3,
  /// <summary>
  /// Specifies a textured line fill.
  /// </summary>
  [OfficeInteropEnumValue("msoLineFillTextured")]
  Textured = 4,
  /// <summary>
  /// Specifies the same fill as the background.
  /// </summary>
  [OfficeInteropEnumValue("msoLineFillBackground")]
  Background = 5,
  /// <summary>
  /// Specifies a picture line fill.
  /// </summary>
  [OfficeInteropEnumValue("msoLineFillPicture")]
  Picture = 6
}
