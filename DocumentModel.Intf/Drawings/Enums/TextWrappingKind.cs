namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Wrapping Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextWrappingKind
{
  /// <summary>
  ///   Text Wrapping Type Enum ( None ).
  /// </summary>
  None,

  /// <summary>
  ///   Text Wrapping Type Enum ( Square ).
  /// </summary>
  Square
}