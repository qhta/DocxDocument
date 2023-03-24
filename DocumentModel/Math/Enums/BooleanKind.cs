namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BooleanValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BooleanKind
{
  /// <summary>
  ///   true.
  /// </summary>
  True,

  /// <summary>
  ///   false.
  /// </summary>
  False,

  /// <summary>
  ///   On.
  /// </summary>
  On,

  /// <summary>
  ///   Off.
  /// </summary>
  Off,

  /// <summary>
  ///   0.
  /// </summary>
  Zero,

  /// <summary>
  ///   1.
  /// </summary>
  One
}