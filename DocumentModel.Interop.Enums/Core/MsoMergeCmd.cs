namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the output of a merge shapes operation.
/// </summary>
public enum MsoMergeCmd
{
  /// <summary>
  /// Creates a new shape from the perimeter of two or more overlapping shapes. The new shape is a set of all the
  /// points from the original shapes. msoMergeCombine2 Creates a new shape from selected shapes. If the selected
  /// shapes overlap, the area where they overlap is cut out, or discarded. msoMergeIntersect3 Forms a new closed
  /// shape from the area where selected shapes overlap, eliminating non-overlapping areas. msoMergeSubtract4
  /// Creates a new shape by subtracting from the primary selection the areas where subsequent selections overlap.
  /// msoMergeFragment5 Breaks a shape into smaller parts or create new shapes from intersecting lines or from
  /// shapes that overlap.
  /// </summary>
  Union = 1,
  /// <summary>
  /// Specifies the output of a merge shapes operation.
  /// </summary>
  Combine,
  /// <summary>
  /// Specifies the output of a merge shapes operation.
  /// </summary>
  Intersect,
  /// <summary>
  /// Specifies the output of a merge shapes operation.
  /// </summary>
  Subtract,
  /// <summary>
  /// Specifies the output of a merge shapes operation.
  /// </summary>
  Fragment
}
