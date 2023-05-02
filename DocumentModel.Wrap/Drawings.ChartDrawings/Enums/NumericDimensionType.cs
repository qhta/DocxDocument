namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NumericDimensionType enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum NumericDimensionType
{
  /// <summary>
  ///   val.
  /// </summary>
  Val,

  /// <summary>
  ///   x.
  /// </summary>
  X,

  /// <summary>
  ///   y.
  /// </summary>
  Y,

  /// <summary>
  ///   size.
  /// </summary>
  Size,

  /// <summary>
  ///   colorVal.
  /// </summary>
  ColorVal
}