namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   End ILine Cap
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LineCapKind
{
  /// <summary>
  ///   Round ILine Cap.
  /// </summary>
  Round,

  /// <summary>
  ///   Square ILine Cap.
  /// </summary>
  Square,

  /// <summary>
  ///   Flat ILine Cap.
  /// </summary>
  Flat
}
