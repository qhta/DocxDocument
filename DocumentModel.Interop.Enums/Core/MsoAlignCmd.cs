namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines how to align specified objects relative to one another.
/// </summary>
public enum MsoAlignCmd
{
  /// <summary>
  /// Align left sides of specified objects.
  /// </summary>
  msoAlignLefts,
  /// <summary>
  /// Align centers of specified objects.
  /// </summary>
  msoAlignCenters,
  /// <summary>
  /// Align right sides of specified objects.
  /// </summary>
  msoAlignRights,
  /// <summary>
  /// Align tops of specified objects.
  /// </summary>
  msoAlignTops,
  /// <summary>
  /// Align middles of specified objects.
  /// </summary>
  msoAlignMiddles,
  /// <summary>
  /// Align bottoms of specified objects.
  /// </summary>
  msoAlignBottoms
}
