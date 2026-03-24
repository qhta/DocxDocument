namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the color of highlighting for table cells that were added, deleted, or merged in the current
/// document.
/// </summary>
public enum WdCellColor
{
  /// <summary>
  /// No highlighting.
  /// </summary>
  NoHighlight = unchecked((int)0),
  /// <summary>
  /// Pink.
  /// </summary>
  Pink = unchecked((int)1),
  /// <summary>
  /// Light blue.
  /// </summary>
  LightBlue = unchecked((int)2),
  /// <summary>
  /// Light yellow.
  /// </summary>
  LightYellow = unchecked((int)3),
  /// <summary>
  /// Light purple.
  /// </summary>
  LightPurple = unchecked((int)4),
  /// <summary>
  /// Light orange.
  /// </summary>
  LightOrange = unchecked((int)5),
  /// <summary>
  /// Light green.
  /// </summary>
  LightGreen = unchecked((int)6),
  /// <summary>
  /// Light gray. [System.Runtime.InteropServices.Guid("347CDE09-0CE2-3FBB-9BB8-7C9ECF5B750E")] public enum
  /// WdCellColor ﾉ Expand table
  /// </summary>
  LightGray = unchecked((int)7),
  /// <summary>
  /// Specifies the color of highlighting for table cells that were added, deleted, or merged in the current
  /// document.
  /// </summary>
  ByAuthor = unchecked((int)-1)
}
