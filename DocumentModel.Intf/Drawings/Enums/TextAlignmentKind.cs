namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Alignment Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextAlignmentKind
{
  /// <summary>
  ///   Text Alignment Enum ( Left ).
  /// </summary>
  Left,

  /// <summary>
  ///   Text Alignment Enum ( Center ).
  /// </summary>
  Center,

  /// <summary>
  ///   Text Alignment Enum ( Right ).
  /// </summary>
  Right,

  /// <summary>
  ///   Text Alignment Enum ( Justified ).
  /// </summary>
  Justified,

  /// <summary>
  ///   Text Alignment Enum ( Justified Low ).
  /// </summary>
  JustifiedLow,

  /// <summary>
  ///   Text Alignment Enum ( Distributed ).
  /// </summary>
  Distributed,

  /// <summary>
  ///   Text Alignment Enum ( Thai Distributed ).
  /// </summary>
  ThaiDistributed
}