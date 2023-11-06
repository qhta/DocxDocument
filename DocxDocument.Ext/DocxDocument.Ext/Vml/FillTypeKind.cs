namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Shape Fill Type
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum FillTypeKind
{
  /// <summary>
  ///   Solid Fill.
  /// </summary>
  Solid,

  /// <summary>
  ///   Linear Gradient.
  /// </summary>
  Gradient,

  /// <summary>
  ///   Radial Gradient.
  /// </summary>
  GradientRadial,

  /// <summary>
  ///   Tiled Image.
  /// </summary>
  Tile,

}