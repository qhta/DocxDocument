namespace DocumentModel.Drawings.Charts;

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