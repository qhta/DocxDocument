namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use as the leader with formatted tabs.
/// </summary>
public enum WdTabLeader
{
  /// <summary>
  /// Spaces. default.
  /// </summary>
  Spaces = unchecked((int)0),
  /// <summary>
  /// Dots.
  /// </summary>
  Dots = unchecked((int)1),
  /// <summary>
  /// Dashes.
  /// </summary>
  Dashes = unchecked((int)2),
  /// <summary>
  /// Double lines.
  /// </summary>
  Lines = unchecked((int)3),
  /// <summary>
  /// A heavy line.
  /// </summary>
  Heavy = unchecked((int)4),
  /// <summary>
  /// A middle dot.
  /// </summary>
  MiddleDot = unchecked((int)5)
}
