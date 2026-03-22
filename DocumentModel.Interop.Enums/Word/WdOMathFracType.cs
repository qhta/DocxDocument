namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of fraction bar.
/// </summary>
public enum WdOMathFracType
{
  /// <summary>
  /// Normal fraction bar.
  /// </summary>
  wdOMathFracBar = unchecked((int)0),
  /// <summary>
  /// No fraction bar.
  /// </summary>
  wdOMathFracNoBar = unchecked((int)1),
  /// <summary>
  /// Skewed fraction bar.
  /// </summary>
  wdOMathFracSkw = unchecked((int)2),
  /// <summary>
  /// Show fraction inline.
  /// </summary>
  wdOMathFracLin = unchecked((int)3)
}
