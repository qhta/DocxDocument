namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the direction that the extrusion's sweep path takes away from the extruded shape (the front face of
/// the extrusion).
/// </summary>
public enum MsoPresetExtrusionDirection
{
  /// <summary>
  /// Specifies the direction that the extrusion's sweep path takes away from the extruded shape (the front face of
  /// the extrusion).
  /// </summary>
  msoPresetExtrusionDirectionMixed = -2,
  /// <summary>
  /// Bottom right.
  /// </summary>
  msoExtrusionBottomRight = 1,
  /// <summary>
  /// Bottom.
  /// </summary>
  msoExtrusionBottom = 2,
  /// <summary>
  /// Bottom left.
  /// </summary>
  msoExtrusionBottomLeft = 3,
  /// <summary>
  /// Right.
  /// </summary>
  msoExtrusionRight = 4,
  /// <summary>
  /// No extrusion.
  /// </summary>
  msoExtrusionNone = 5,
  /// <summary>
  /// Left.
  /// </summary>
  msoExtrusionLeft = 6,
  /// <summary>
  /// Top right.
  /// </summary>
  msoExtrusionTopRight = 7,
  /// <summary>
  /// Top.
  /// </summary>
  msoExtrusionTop = 8,
  /// <summary>
  /// Top left.
  /// </summary>
  msoExtrusionTopLeft = 9
}
