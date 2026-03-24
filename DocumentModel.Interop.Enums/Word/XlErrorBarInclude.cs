namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which error-bar parts to include.
/// </summary>
public enum XlErrorBarInclude
{
  /// <summary>
  /// Both positive and negative error range.
  /// </summary>
  Both = unchecked((int)1),
  /// <summary>
  /// Only positive error range.
  /// </summary>
  PlusValues = unchecked((int)2),
  /// <summary>
  /// Only negative error range.
  /// </summary>
  MinusValues = unchecked((int)3),
  /// <summary>
  /// Specifies which error-bar parts to include.
  /// </summary>
  None = unchecked((int)-4142)
}
