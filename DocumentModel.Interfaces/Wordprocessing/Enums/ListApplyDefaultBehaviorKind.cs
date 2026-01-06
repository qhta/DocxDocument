namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the default behavior when applying a list template.
/// </summary>
public enum ListApplyDefaultBehaviorKind
{
  /// <summary>Apply Word 2002 and earlier behavior</summary>
  Word2002Behavior = 0,
  /// <summary>Apply Word 2003 and later behavior</summary>
  Word2003Behavior = 1
}