namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Shape
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ShapeKind
{
  /// <summary>
  ///   Cone.
  /// </summary>
  Cone,

  /// <summary>
  ///   Cone to Max.
  /// </summary>
  ConeToMax,

  /// <summary>
  ///   Box.
  /// </summary>
  Box,

  /// <summary>
  ///   Cylinder.
  /// </summary>
  Cylinder,

  /// <summary>
  ///   Pyramid.
  /// </summary>
  Pyramid,

  /// <summary>
  ///   Pyramid to Maximum.
  /// </summary>
  PyramidToMaximum
}