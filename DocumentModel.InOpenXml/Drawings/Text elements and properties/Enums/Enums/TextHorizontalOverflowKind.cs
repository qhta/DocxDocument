namespace DocumentModel.Drawings;

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