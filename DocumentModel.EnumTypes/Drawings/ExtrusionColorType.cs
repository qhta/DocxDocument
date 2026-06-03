namespace DocumentModel.Drawings;

/// <summary>
/// Specifies whether the extrusion color is based on the extruded shape's fill (the front face of the extrusion)
/// and automatically changes when the shape's fill changes, or whether the extrusion color is independent of the
/// shape's fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoextrusioncolortype?view=office-pia` for Office interop details.
/// </remarks>
public enum ExtrusionColorType
{
  /// <summary>
  /// Return value Ionly; indicates a combination of the other states.
  /// </summary>
  TypeMixed = -2,
  /// <summary>
  /// Extrusion color is based on shape fill.
  /// </summary>
  Automatic = 1,
  /// <summary>
  /// Extrusion color is independent of shape fill.
  /// </summary>
  Custom = 2
}

