namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of equation function.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathfunctiontype?view=office-pia` for Office interop details.
/// </remarks>
public enum OMathFunctionType
{
  /// <summary>
  /// Equation accent mark.
  /// </summary>
  Acc = 1,
  /// <summary>
  /// Equation fraction bar.
  /// </summary>
  Bar = 2,
  /// <summary>
  /// Box.
  /// </summary>
  Box = 3,
  /// <summary>
  /// Border box.
  /// </summary>
  BorderBox = 4,
  /// <summary>
  /// Equation delimiters.
  /// </summary>
  Delim = 5,
  /// <summary>
  /// Equation array.
  /// </summary>
  EqArray = 6,
  /// <summary>
  /// Equation fraction.
  /// </summary>
  Frac = 7,
  /// <summary>
  /// Equation function.
  /// </summary>
  Func = 8,
  /// <summary>
  /// Group character.
  /// </summary>
  GroupChar = 9,
  /// <summary>
  /// Equation lower limit.
  /// </summary>
  LimLow = 10,
  /// <summary>
  /// Equation upper limit.
  /// </summary>
  LimUpp = 11,
  /// <summary>
  /// Equation matrix.
  /// </summary>
  Mat = 12,
  /// <summary>
  /// Equation N-ary operator.
  /// </summary>
  Nary = 13,
  /// <summary>
  /// Equation phantom.
  /// </summary>
  Phantom = 14,
  /// <summary>
  /// Scr pre.
  /// </summary>
  ScrPre = 15,
  /// <summary>
  /// Equation base expression.
  /// </summary>
  Rad = 16,
  /// <summary>
  /// Scr. sub.
  /// </summary>
  ScrSub = 17,
  /// <summary>
  /// Scr. sub sup.
  /// </summary>
  ScrSubSup = 18,
  /// <summary>
  /// Scr sup.
  /// </summary>
  ScrSup = 19,
  /// <summary>
  /// Equation text.
  /// </summary>
  Text = 20,
  /// <summary>
  /// Equation normal text.
  /// </summary>
  NormalText = 21,
  /// <summary>
  /// Equation literal text.
  /// </summary>
  LiteralText = 22
}
