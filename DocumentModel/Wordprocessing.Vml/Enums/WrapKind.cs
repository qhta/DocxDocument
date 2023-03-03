namespace DocumentModel.Wordprocessing.Vml;

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