namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of fraction bar.
/// </summary>
public enum WdOMathFracType
{
  /// <summary>
  /// Normal fraction bar.
  /// </summary>
  Bar = unchecked((int)0),
  /// <summary>
  /// No fraction bar.
  /// </summary>
  NoBar = unchecked((int)1),
  /// <summary>
  /// Skewed fraction bar.
  /// </summary>
  Skw = unchecked((int)2),
  /// <summary>
  /// Show fraction inline.
  /// </summary>
  Lin = unchecked((int)3)
}
