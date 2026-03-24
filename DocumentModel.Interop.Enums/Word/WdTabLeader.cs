namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use as the leader with formatted tabs.
/// </summary>
public enum WdTabLeader
{
  /// <summary>
  /// Spaces. default.
  /// </summary>
  Spaces = 0,
  /// <summary>
  /// Dots.
  /// </summary>
  Dots = 1,
  /// <summary>
  /// Dashes.
  /// </summary>
  Dashes = 2,
  /// <summary>
  /// Double lines.
  /// </summary>
  Lines = 3,
  /// <summary>
  /// A heavy line.
  /// </summary>
  Heavy = 4,
  /// <summary>
  /// A middle dot.
  /// </summary>
  MiddleDot = 5
}
