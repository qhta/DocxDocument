namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Orientation
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum OrientationKind
{
  /// <summary>
  ///   Maximum Ito Minimum.
  /// </summary>
  MaxMin,

  /// <summary>
  ///   Minimum Ito Maximum.
  /// </summary>
  MinMax
}
