namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether the extrusion color is based on the extruded shape's fill (the front face of the extrusion)
/// and automatically changes when the shape's fill changes, or whether the extrusion color is independent of the
/// shape's fill.
/// </summary>
public enum MsoExtrusionColorType
{
  /// <summary>
  /// Specifies whether the extrusion color is based on the extruded shape's fill (the front face of the extrusion)
  /// and automatically changes when the shape's fill changes, or whether the extrusion color is independent of the
  /// shape's fill.
  /// </summary>
  msoExtrusionColorTypeMixed = -2,
  /// <summary>
  /// Specifies whether the extrusion color is based on the extruded shape's fill (the front face of the extrusion)
  /// and automatically changes when the shape's fill changes, or whether the extrusion color is independent of the
  /// shape's fill.
  /// </summary>
  msoExtrusionColorAutomatic = 1,
  /// <summary>
  /// Specifies whether the extrusion color is based on the extruded shape's fill (the front face of the extrusion)
  /// and automatically changes when the shape's fill changes, or whether the extrusion color is independent of the
  /// shape's fill.
  /// </summary>
  msoExtrusionColorCustom = 2
}
