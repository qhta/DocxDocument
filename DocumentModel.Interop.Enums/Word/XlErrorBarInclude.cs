namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which error-bar parts to include.
/// </summary>
public enum XlErrorBarInclude
{
  /// <summary>
  /// Both positive and negative error range.
  /// </summary>
  xlErrorBarIncludeBoth = unchecked((int)1),
  /// <summary>
  /// Only positive error range.
  /// </summary>
  xlErrorBarIncludePlusValues = unchecked((int)2),
  /// <summary>
  /// Only negative error range.
  /// </summary>
  xlErrorBarIncludeMinusValues = unchecked((int)3),
  /// <summary>
  /// Specifies which error-bar parts to include.
  /// </summary>
  xlErrorBarIncludeNone = unchecked((int)-4142)
}
