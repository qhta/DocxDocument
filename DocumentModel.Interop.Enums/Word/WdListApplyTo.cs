namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the portion of a list to which to apply a list template.
/// </summary>
public enum WdListApplyTo
{
  /// <summary>
  /// Entire list.
  /// </summary>
  WholeList = unchecked((int)0),
  /// <summary>
  /// From cursor insertion point to end of list.
  /// </summary>
  ThisPointForward = unchecked((int)1),
  /// <summary>
  /// Selection.
  /// </summary>
  Selection = unchecked((int)2)
}
