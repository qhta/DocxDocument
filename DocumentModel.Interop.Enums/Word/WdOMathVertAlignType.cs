namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the vertical alignment of equations within the shape canvas or the line, for inline equations.
/// </summary>
public enum WdOMathVertAlignType
{
  /// <summary>
  /// Specifies the vertical alignment of equations within the shape canvas or the line, for inline equations.
  /// </summary>
  wdOMathVertAlignCenter = unchecked((int)0),
  /// <summary>
  /// Aligns the equation on the top of the shape canvas or line. wdOMathVertAlignBottom2 Aligns the equation on the
  /// bottom of the shape canvas or line.
  /// </summary>
  wdOMathVertAlignTop = unchecked((int)1),
  /// <summary>
  /// Specifies the vertical alignment of equations within the shape canvas or the line, for inline equations.
  /// </summary>
  wdOMathVertAlignBottom = unchecked((int)2)
}
