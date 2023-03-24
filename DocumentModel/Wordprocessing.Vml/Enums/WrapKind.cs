namespace DocumentModel.Wordprocessing.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Wrapping Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum WrapKind
{
  /// <summary>
  ///   Top and bottom wrapping.
  /// </summary>
  TopAndBottom,

  /// <summary>
  ///   Square wrapping.
  /// </summary>
  Square,

  /// <summary>
  ///   No wrapping.
  /// </summary>
  None,

  /// <summary>
  ///   Tight wrapping.
  /// </summary>
  Tight,

  /// <summary>
  ///   Through wrapping.
  /// </summary>
  Through
}