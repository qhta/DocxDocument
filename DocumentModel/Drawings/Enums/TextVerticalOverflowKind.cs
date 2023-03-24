namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Vertical Overflow
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextVerticalOverflowKind
{
  /// <summary>
  ///   Text Overflow Enum ( Overflow ).
  /// </summary>
  Overflow,

  /// <summary>
  ///   Text Overflow Enum ( Ellipsis ).
  /// </summary>
  Ellipsis,

  /// <summary>
  ///   Text Overflow Enum ( Clip ).
  /// </summary>
  Clip
}