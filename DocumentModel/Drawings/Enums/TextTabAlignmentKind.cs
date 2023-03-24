namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Tab Alignment Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextTabAlignmentKind
{
  /// <summary>
  ///   Text Tab Alignment Enum ( Left).
  /// </summary>
  Left,

  /// <summary>
  ///   Text Tab Alignment Enum ( Center ).
  /// </summary>
  Center,

  /// <summary>
  ///   Text Tab Alignment Enum ( Right ).
  /// </summary>
  Right,

  /// <summary>
  ///   Text Tab Alignment Enum ( Decimal ).
  /// </summary>
  Decimal
}