namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies where a node is added to a diagram relative to existing nodes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msorelativenodeposition?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoRelativeNodePosition")]
public enum RelativeNodePosition
{
  /// <summary>
  /// Node is added before current node.
  /// </summary>
  [InteropEnumValue("msoBeforeNode")]
  BeforeNode = 1,
  /// <summary>
  /// Node is added after current node.
  /// </summary>
  [InteropEnumValue("msoAfterNode")]
  AfterNode,
  /// <summary>
  /// Node is added before first sibling.
  /// </summary>
  [InteropEnumValue("msoBeforeFirstSibling")]
  BeforeFirstSibling,
  /// <summary>
  /// Node is added after last sibling.
  /// </summary>
  [InteropEnumValue("msoAfterLastSibling")]
  AfterLastSibling
}
