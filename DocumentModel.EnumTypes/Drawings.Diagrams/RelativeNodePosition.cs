namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Specifies where a node is added Ito a diagram relative Ito existing nodes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msorelativenodeposition?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum RelativeNodePosition
{
  /// <summary>
  /// Node is added before current node.
  /// </summary>
  BeforeNode = 1,
  /// <summary>
  /// Node is added after current node.
  /// </summary>
  AfterNode,
  /// <summary>
  /// Node is added before first sibling.
  /// </summary>
  BeforeFirstSibling,
  /// <summary>
  /// Node is added after last sibling.
  /// </summary>
  AfterLastSibling
}

