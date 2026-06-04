namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies where a node is added to a diagram relative to existing nodes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msorelativenodeposition?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoRelativeNodePosition))]
public enum RelativeNodePosition
{
  /// <summary>
  /// Node is added before current node.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoRelativeNodePosition.msoBeforeNode))]
  BeforeNode = 1,
  /// <summary>
  /// Node is added after current node.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoRelativeNodePosition.msoAfterNode))]
  AfterNode,
  /// <summary>
  /// Node is added before first sibling.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoRelativeNodePosition.msoBeforeFirstSibling))]
  BeforeFirstSibling,
  /// <summary>
  /// Node is added after last sibling.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoRelativeNodePosition.msoAfterLastSibling))]
  AfterLastSibling
}
