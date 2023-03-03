namespace DocumentModel.Drawings;

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