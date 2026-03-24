namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of equation function.
/// </summary>
public enum WdOMathFunctionType
{
  /// <summary>
  /// Equation accent mark.
  /// </summary>
  Acc = unchecked((int)1),
  /// <summary>
  /// Equation fraction bar.
  /// </summary>
  Bar = unchecked((int)2),
  /// <summary>
  /// Box.
  /// </summary>
  Box = unchecked((int)3),
  /// <summary>
  /// Border box.
  /// </summary>
  BorderBox = unchecked((int)4),
  /// <summary>
  /// Equation delimiters.
  /// </summary>
  Delim = unchecked((int)5),
  /// <summary>
  /// Equation array.
  /// </summary>
  EqArray = unchecked((int)6),
  /// <summary>
  /// Equation fraction.
  /// </summary>
  Frac = unchecked((int)7),
  /// <summary>
  /// Equation function.
  /// </summary>
  Func = unchecked((int)8),
  /// <summary>
  /// Group character.
  /// </summary>
  GroupChar = unchecked((int)9),
  /// <summary>
  /// Equation lower limit.
  /// </summary>
  LimLow = unchecked((int)10),
  /// <summary>
  /// Equation upper limit. [System.Runtime.InteropServices.Guid("74779721-3C00-363D-BED4-B0AF3595EB05")] public
  /// enum WdOMathFunctionType ﾉ Expand table
  /// </summary>
  LimUpp = unchecked((int)11),
  /// <summary>
  /// Equation matrix.
  /// </summary>
  Mat = unchecked((int)12),
  /// <summary>
  /// Equation N-ary operator.
  /// </summary>
  Nary = unchecked((int)13),
  /// <summary>
  /// Equation phantom.
  /// </summary>
  Phantom = unchecked((int)14),
  /// <summary>
  /// Scr pre.
  /// </summary>
  ScrPre = unchecked((int)15),
  /// <summary>
  /// Equation base expression.
  /// </summary>
  Rad = unchecked((int)16),
  /// <summary>
  /// Scr. sub.
  /// </summary>
  ScrSub = unchecked((int)17),
  /// <summary>
  /// Scr. sub sup.
  /// </summary>
  ScrSubSup = unchecked((int)18),
  /// <summary>
  /// Scr sup.
  /// </summary>
  ScrSup = unchecked((int)19),
  /// <summary>
  /// Equation text.
  /// </summary>
  Text = unchecked((int)20),
  /// <summary>
  /// Equation normal text.
  /// </summary>
  NormalText = unchecked((int)21),
  /// <summary>
  /// Equation literal text.
  /// </summary>
  LiteralText = unchecked((int)22)
}
