namespace DocumentModel.Drawings;

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