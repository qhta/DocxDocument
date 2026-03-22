namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the editing type of a node.
/// </summary>
public enum MsoEditingType
{
  /// <summary>
  /// Editing type is appropriate to the segments being connected.
  /// </summary>
  Auto,
  /// <summary>
  /// Corner node.
  /// </summary>
  Corner,
  /// <summary>
  /// Smooth node.
  /// </summary>
  Smooth,
  /// <summary>
  /// Symmetric node.
  /// </summary>
  Symmetric
}
