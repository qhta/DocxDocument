namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Orientation
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum OrientationKind
{
  /// <summary>
  ///   Maximum to Minimum.
  /// </summary>
  MaxMin,

  /// <summary>
  ///   Minimum to Maximum.
  /// </summary>
  MinMax
}