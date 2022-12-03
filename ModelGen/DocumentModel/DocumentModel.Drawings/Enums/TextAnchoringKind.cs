namespace DocumentModel.Drawings;

/// <summary>
/// Text Anchoring Types
/// </summary>
public enum TextAnchoringKind
{
  /// <summary>
  /// Text Anchoring Type Enum ( Top ).
  /// </summary>
  [XmlEnum("t")]
  Top,
  
  /// <summary>
  /// Text Anchor Enum ( Center ).
  /// </summary>
  [XmlEnum("ctr")]
  Center,
  
  /// <summary>
  /// Text Anchor Enum ( Bottom ).
  /// </summary>
  [XmlEnum("b")]
  Bottom,
  
}
