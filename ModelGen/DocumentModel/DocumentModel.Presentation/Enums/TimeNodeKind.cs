namespace DocumentModel.Presentation;

/// <summary>
/// Time Node Type
/// </summary>
public enum TimeNodeKind
{
  /// <summary>
  /// Node Type Enum ( Click Effect ).
  /// </summary>
  ClickEffect,
  
  /// <summary>
  /// Node Type Enum ( With Effect ).
  /// </summary>
  WithEffect,
  
  /// <summary>
  /// Node Type Enum ( After Effect ).
  /// </summary>
  AfterEffect,
  
  /// <summary>
  /// Node Type Enum ( Main Sequence ).
  /// </summary>
  MainSequence,
  
  /// <summary>
  /// Node Type Enum ( Interactive Sequence ).
  /// </summary>
  InteractiveSequence,
  
  /// <summary>
  /// Node Type Enum ( Click Paragraph ).
  /// </summary>
  ClickParagraph,
  
  /// <summary>
  /// Node Type Enum ( With Group ).
  /// </summary>
  WithGroup,
  
  /// <summary>
  /// Node Type Enum ( After Group ).
  /// </summary>
  AfterGroup,
  
  /// <summary>
  /// Node Type Enum ( Timing Root ).
  /// </summary>
  TmingRoot,
  
}
