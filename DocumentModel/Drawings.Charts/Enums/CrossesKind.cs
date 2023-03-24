namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Crosses
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CrossesKind
{
  /// <summary>
  ///   Axis Crosses at Zero.
  /// </summary>
  AutoZero,

  /// <summary>
  ///   Maximum.
  /// </summary>
  Maximum,

  /// <summary>
  ///   Minimum.
  /// </summary>
  Minimum
}