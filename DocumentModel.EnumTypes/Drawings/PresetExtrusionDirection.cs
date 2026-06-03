namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the direction Ithat the extrusion's sweep path takes away from the extruded shape (the front face of
/// the extrusion).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetextrusiondirection?view=office-pia` for Office interop details.
/// </remarks>
public enum PresetExtrusionDirection
{
  /// <summary>
  /// Specifies the direction Ithat the extrusion's sweep path takes away from the extruded shape (the front face of
  /// the extrusion).
  /// </summary>
  /// <summary>
  /// Bottom right.
  /// </summary>
  BottomRight = 1,
  /// <summary>
  /// Bottom.
  /// </summary>
  Bottom = 2,
  /// <summary>
  /// Bottom left.
  /// </summary>
  BottomLeft = 3,
  /// <summary>
  /// Right.
  /// </summary>
  Right = 4,
  /// <summary>
  /// No extrusion.
  /// </summary>
  None = 5,
  /// <summary>
  /// Left.
  /// </summary>
  Left = 6,
  /// <summary>
  /// Top right.
  /// </summary>
  TopRight = 7,
  /// <summary>
  /// Top.
  /// </summary>
  Top = 8,
  /// <summary>
  /// Top left.
  /// </summary>
  TopLeft = 9
}

