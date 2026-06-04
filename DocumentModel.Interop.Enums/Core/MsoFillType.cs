namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a shape's fill type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilltype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFillType))]
public enum FillType
{
  /// <summary>
  /// Mixed fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFillType.msoFillMixed))]
  Mixed = -2,
  /// <summary>
  /// Solid fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFillType.msoFillSolid))]
  Solid = 1,
  /// <summary>
  /// Patterned fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFillType.msoFillPatterned))]
  Patterned = 2,
  /// <summary>
  /// Gradient fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFillType.msoFillGradient))]
  Gradient = 3,
  /// <summary>
  /// Textured fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFillType.msoFillTextured))]
  Textured = 4,
  /// <summary>
  /// Fill is the same as the background.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFillType.msoFillBackground))]
  Background = 5,
  /// <summary>
  /// Picture fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFillType.msoFillPicture))]
  Picture = 6
}
