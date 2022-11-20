namespace DocumentModel.Presentation;

/// <summary>
/// Time Node Type
/// </summary>
public enum TimeNodeValues
{
  /// <summary>
  /// Node Type Enum ( Click Effect ).
  /// </summary>
  [XmlEnum("clickEffect")]
  ClickEffect,
  
  /// <summary>
  /// Node Type Enum ( With Effect ).
  /// </summary>
  [XmlEnum("withEffect")]
  WithEffect,
  
  /// <summary>
  /// Node Type Enum ( After Effect ).
  /// </summary>
  [XmlEnum("afterEffect")]
  AfterEffect,
  
  /// <summary>
  /// Node Type Enum ( Main Sequence ).
  /// </summary>
  [XmlEnum("mainSeq")]
  MainSequence,
  
  /// <summary>
  /// Node Type Enum ( Interactive Sequence ).
  /// </summary>
  [XmlEnum("interactiveSeq")]
  InteractiveSequence,
  
  /// <summary>
  /// Node Type Enum ( Click Paragraph ).
  /// </summary>
  [XmlEnum("clickPar")]
  ClickParagraph,
  
  /// <summary>
  /// Node Type Enum ( With Group ).
  /// </summary>
  [XmlEnum("withGroup")]
  WithGroup,
  
  /// <summary>
  /// Node Type Enum ( After Group ).
  /// </summary>
  [XmlEnum("afterGroup")]
  AfterGroup,
  
  /// <summary>
  /// Node Type Enum ( Timing Root ).
  /// </summary>
  [XmlEnum("tmRoot")]
  TmingRoot,
  
}
