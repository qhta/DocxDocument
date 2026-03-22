namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the editing type of a node.
/// </summary>
public enum MsoEditingType
{
  /// <summary>
  /// Editing type is appropriate to the segments being connected.
  /// </summary>
  msoEditingAuto,
  /// <summary>
  /// Corner node.
  /// </summary>
  msoEditingCorner,
  /// <summary>
  /// Smooth node.
  /// </summary>
  msoEditingSmooth,
  /// <summary>
  /// Symmetric node.
  /// </summary>
  msoEditingSymmetric
}
