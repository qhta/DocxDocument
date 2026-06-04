namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of fill for a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinefilltype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoLineFillType))]
public enum LineFillType
{
  /// <summary>
  /// Specifies a mixture of line fill types.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineFillType.msoLineFillMixed))]
  Mixed = -2,
  /// <summary>
  /// No line fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineFillType.msoLineFillNone))]
  None = 0,
  /// <summary>
  /// Specifies a solid color line fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineFillType.msoLineFillSolid))]
  Solid = 1,
  /// <summary>
  /// Specifies a pattern line fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineFillType.msoLineFillPatterned))]
  Patterned = 2,
  /// <summary>
  /// Specifies a gradient line fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineFillType.msoLineFillGradient))]
  Gradient = 3,
  /// <summary>
  /// Specifies a textured line fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineFillType.msoLineFillTextured))]
  Textured = 4,
  /// <summary>
  /// Specifies the same fill as the background.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineFillType.msoLineFillBackground))]
  Background = 5,
  /// <summary>
  /// Specifies a picture line fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineFillType.msoLineFillPicture))]
  Picture = 6
}
