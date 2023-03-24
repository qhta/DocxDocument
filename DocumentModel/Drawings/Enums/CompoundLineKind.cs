namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Compound Line Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CompoundLineKind
{
  /// <summary>
  ///   Single Line.
  /// </summary>
  Single,

  /// <summary>
  ///   Double Lines.
  /// </summary>
  Double,

  /// <summary>
  ///   Thick Thin Double Lines.
  /// </summary>
  ThickThin,

  /// <summary>
  ///   Thin Thick Double Lines.
  /// </summary>
  ThinThick,

  /// <summary>
  ///   Thin Thick Thin Triple Lines.
  /// </summary>
  Triple
}