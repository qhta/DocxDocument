namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use as the leader with formatted tabs.
/// </summary>
public enum WdTabLeader
{
  /// <summary>
  /// Spaces. default.
  /// </summary>
  wdTabLeaderSpaces = unchecked((int)0),
  /// <summary>
  /// Dots.
  /// </summary>
  wdTabLeaderDots = unchecked((int)1),
  /// <summary>
  /// Dashes.
  /// </summary>
  wdTabLeaderDashes = unchecked((int)2),
  /// <summary>
  /// Double lines.
  /// </summary>
  wdTabLeaderLines = unchecked((int)3),
  /// <summary>
  /// A heavy line.
  /// </summary>
  wdTabLeaderHeavy = unchecked((int)4),
  /// <summary>
  /// A middle dot.
  /// </summary>
  wdTabLeaderMiddleDot = unchecked((int)5)
}
