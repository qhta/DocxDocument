namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
