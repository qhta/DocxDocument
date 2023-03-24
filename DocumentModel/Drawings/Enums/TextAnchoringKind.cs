namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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