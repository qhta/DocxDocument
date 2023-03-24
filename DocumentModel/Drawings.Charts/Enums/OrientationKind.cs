namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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