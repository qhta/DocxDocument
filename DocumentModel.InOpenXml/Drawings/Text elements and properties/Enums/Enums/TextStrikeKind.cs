namespace DocumentModel.Drawings;

/// <summary>
///   Text Strike Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextStrikeKind
{
  /// <summary>
  ///   Text Strike Enum ( No Strike ).
  /// </summary>
  NoStrike,
  /// <summary>
  ///   Text Strike Enum ( Single Strike ).
  /// </summary>
  SingleStrike,
  /// <summary>
  ///   Text Strike Enum ( Double Strike ).
  /// </summary>
  DoubleStrike
}