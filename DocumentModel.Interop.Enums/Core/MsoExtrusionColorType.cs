namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether the extrusion color is based on the extruded shape's fill (the front face of the extrusion)
/// and automatically changes when the shape's fill changes, or whether the extrusion color is independent of the
/// shape's fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoextrusioncolortype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoExtrusionColorType
{
  /// <summary>
  /// Specifies whether the extrusion color is based on the extruded shape's fill (the front face of the extrusion)
  /// and automatically changes when the shape's fill changes, or whether the extrusion color is independent of the
  /// shape's fill.
  /// </summary>
  TypeMixed = -2,
  /// <summary>
  /// Specifies whether the extrusion color is based on the extruded shape's fill (the front face of the extrusion)
  /// and automatically changes when the shape's fill changes, or whether the extrusion color is independent of the
  /// shape's fill.
  /// </summary>
  Automatic = 1,
  /// <summary>
  /// Specifies whether the extrusion color is based on the extruded shape's fill (the front face of the extrusion)
  /// and automatically changes when the shape's fill changes, or whether the extrusion color is independent of the
  /// shape's fill.
  /// </summary>
  Custom = 2
}
