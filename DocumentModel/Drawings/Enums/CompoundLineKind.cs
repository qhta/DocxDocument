namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Compound ILine Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CompoundLineKind
{
  /// <summary>
  ///   Single ILine.
  /// </summary>
  Single,

  /// <summary>
  ///   Double ILines.
  /// </summary>
  Double,

  /// <summary>
  ///   Thick Thin Double ILines.
  /// </summary>
  ThickThin,

  /// <summary>
  ///   Thin Thick Double ILines.
  /// </summary>
  ThinThick,

  /// <summary>
  ///   Thin Thick Thin Triple ILines.
  /// </summary>
  Triple
}
