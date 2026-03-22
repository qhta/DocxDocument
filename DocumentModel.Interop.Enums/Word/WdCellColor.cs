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
  wdCellColorNoHighlight = unchecked((int)0),
  /// <summary>
  /// Pink.
  /// </summary>
  wdCellColorPink = unchecked((int)1),
  /// <summary>
  /// Light blue.
  /// </summary>
  wdCellColorLightBlue = unchecked((int)2),
  /// <summary>
  /// Light yellow.
  /// </summary>
  wdCellColorLightYellow = unchecked((int)3),
  /// <summary>
  /// Light purple.
  /// </summary>
  wdCellColorLightPurple = unchecked((int)4),
  /// <summary>
  /// Light orange.
  /// </summary>
  wdCellColorLightOrange = unchecked((int)5),
  /// <summary>
  /// Light green.
  /// </summary>
  wdCellColorLightGreen = unchecked((int)6),
  /// <summary>
  /// Light gray. [System.Runtime.InteropServices.Guid("347CDE09-0CE2-3FBB-9BB8-7C9ECF5B750E")] public enum
  /// WdCellColor ﾉ Expand table
  /// </summary>
  wdCellColorLightGray = unchecked((int)7),
  /// <summary>
  /// Specifies the color of highlighting for table cells that were added, deleted, or merged in the current
  /// document.
  /// </summary>
  wdCellColorByAuthor = unchecked((int)-1)
}
