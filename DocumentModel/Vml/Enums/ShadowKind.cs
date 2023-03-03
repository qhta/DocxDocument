namespace DocumentModel.Vml;

/// <summary>
///   Shadow Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ShadowKind
{
  /// <summary>
  ///   Single Shadow.
  /// </summary>
  Single,

  /// <summary>
  ///   Double Shadow.
  /// </summary>
  Double,

  /// <summary>
  ///   Embossed Shadow.
  /// </summary>
  Emboss,

  /// <summary>
  ///   Perspective Shadow.
  /// </summary>
  Perspective,

  /// <summary>
  ///   shapeRelative.
  /// </summary>
  ShapeRelative,

  /// <summary>
  ///   drawingRelative.
  /// </summary>
  DrawingRelative
}