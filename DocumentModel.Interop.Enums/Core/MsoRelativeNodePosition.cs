namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies where a node is added to a diagram relative to existing nodes.
/// </summary>
public enum MsoRelativeNodePosition
{
  /// <summary>
  /// Node is added before current node.
  /// </summary>
  msoBeforeNode = 1,
  /// <summary>
  /// Node is added after current node.
  /// </summary>
  msoAfterNode,
  /// <summary>
  /// Node is added before first sibling.
  /// </summary>
  msoBeforeFirstSibling,
  /// <summary>
  /// Node is added after last sibling.
  /// </summary>
  msoAfterLastSibling
}
