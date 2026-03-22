
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the shape
/// used with the 3-D bar or column chart.
/// </summary>
public enum XlBarShape
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Box.
  /// </summary>
  xlBox,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Pyramid, coming to
  /// point at value.
  /// </summary>
  xlPyramidToPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Pyramid, truncated
  /// at value.
  /// </summary>
  xlPyramidToMax,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Cylinder.
  /// </summary>
  xlCylinder,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Cone, coming to
  /// point at value.
  /// </summary>
  xlConeToPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Cone, truncated at
  /// value.
  /// </summary>
  xlConeToMax
}
