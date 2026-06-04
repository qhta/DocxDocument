namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether the extrusion color is based on the extruded shape's fill (the front face of the extrusion)
/// and automatically changes when the shape's fill changes, or whether the extrusion color is independent of the
/// shape's fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoextrusioncolortype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoExtrusionColorType))]
public enum ExtrusionColorType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoExtrusionColorType.msoExtrusionColorTypeMixed))]
  TypeMixed = -2,
  /// <summary>
  /// Extrusion color is based on shape fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoExtrusionColorType.msoExtrusionColorAutomatic))]
  Automatic = 1,
  /// <summary>
  /// Extrusion color is independent of shape fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoExtrusionColorType.msoExtrusionColorCustom))]
  Custom = 2
}
