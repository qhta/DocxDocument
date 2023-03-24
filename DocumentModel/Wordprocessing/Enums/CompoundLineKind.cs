namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  ///   tri.
  /// </summary>
  Triple
}