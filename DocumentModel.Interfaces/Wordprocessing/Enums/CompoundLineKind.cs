namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CompoundLineValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CompoundLineKind
{
  /// <summary>
  ///   sng.
  /// </summary>
  Simple,
  /// <summary>
  ///   dbl.
  /// </summary>
  Double,
  /// <summary>
  ///   thickThin.
  /// </summary>
  ThickThin,
  /// <summary>
  ///   thinThick.
  /// </summary>
  ThinThick,
  /// <summary>
  ///   triple
  /// </summary>
  Triple
}