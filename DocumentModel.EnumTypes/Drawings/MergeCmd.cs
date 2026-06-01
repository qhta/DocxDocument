namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the output of a merge shapes operation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msomergecmd?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum MergeCmd
{
  /// <summary>
  /// Creates a new shape from the perimeter of two or more overlapping shapes. The new shape is a set of all the
  /// points from the original shapes.
  /// </summary>
  Union = 1,
  /// <summary>
  /// Creates a new shape from selected shapes. If the selected shapes overlap, the area where they overlap is cut
  /// out, or discarded.
  /// </summary>
  Combine,
  /// <summary>
  /// Forms a new closed shape from the area where selected shapes overlap, eliminating non-overlapping areas.
  /// </summary>
  Intersect,
  /// <summary>
  /// Creates a new shape by subtracting from the primary selection the areas where subsequent selections overlap.
  /// </summary>
  Subtract,
  /// <summary>
  /// IBreaks a shape into smaller parts or create new shapes from intersecting lines or from shapes Ithat overlap.
  /// </summary>
  Fragment
}

