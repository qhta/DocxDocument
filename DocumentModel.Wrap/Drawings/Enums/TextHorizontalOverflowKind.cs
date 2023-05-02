namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Horizontal Overflow Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextHorizontalOverflowKind
{
  /// <summary>
  ///   Text Horizontal Overflow Enum ( Overflow ).
  /// </summary>
  Overflow,

  /// <summary>
  ///   Text Horizontal Overflow Enum ( Clip ).
  /// </summary>
  Clip
}