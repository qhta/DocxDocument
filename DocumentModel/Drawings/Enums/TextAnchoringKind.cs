namespace DocumentModel.Drawings;

/// <summary>
///   Text Anchoring Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextAnchoringKind
{
  /// <summary>
  ///   Text Anchoring Type Enum ( Top ).
  /// </summary>
  Top,

  /// <summary>
  ///   Text Anchor Enum ( Center ).
  /// </summary>
  Center,

  /// <summary>
  ///   Text Anchor Enum ( Bottom ).
  /// </summary>
  Bottom
}