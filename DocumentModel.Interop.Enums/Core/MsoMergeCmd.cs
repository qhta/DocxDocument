namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the output of a merge shapes operation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msomergecmd?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoMergeCmd))]
public enum MergeCmd
{
  /// <summary>
  /// Creates a new shape from the perimeter of two or more overlapping shapes. The new shape is a set of all the
  /// points from the original shapes.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMergeCmd.msoMergeUnion))]
  Union = 1,
  /// <summary>
  /// Creates a new shape from selected shapes. If the selected shapes overlap, the area where they overlap is cut
  /// out, or discarded.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMergeCmd.msoMergeCombine))]
  Combine,
  /// <summary>
  /// Forms a new closed shape from the area where selected shapes overlap, eliminating non-overlapping areas.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMergeCmd.msoMergeIntersect))]
  Intersect,
  /// <summary>
  /// Creates a new shape by subtracting from the primary selection the areas where subsequent selections overlap.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMergeCmd.msoMergeSubtract))]
  Subtract,
  /// <summary>
  /// Breaks a shape into smaller parts or create new shapes from intersecting lines or from shapes that overlap.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMergeCmd.msoMergeFragment))]
  Fragment
}
