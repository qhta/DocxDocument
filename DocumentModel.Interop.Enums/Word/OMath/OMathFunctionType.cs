namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of equation function.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathfunctiontype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdOMathFunctionType")]
public enum OMathFunctionType
{
  /// <summary>
  /// Equation accent mark.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionAcc")]
  Acc = 1,
  /// <summary>
  /// Equation fraction bar.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionBar")]
  Bar = 2,
  /// <summary>
  /// Box.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionBox")]
  Box = 3,
  /// <summary>
  /// Border box.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionBorderBox")]
  BorderBox = 4,
  /// <summary>
  /// Equation delimiters.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionDelim")]
  Delim = 5,
  /// <summary>
  /// Equation array.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionEqArray")]
  EqArray = 6,
  /// <summary>
  /// Equation fraction.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionFrac")]
  Frac = 7,
  /// <summary>
  /// Equation function.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionFunc")]
  Func = 8,
  /// <summary>
  /// Group character.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionGroupChar")]
  GroupChar = 9,
  /// <summary>
  /// Equation lower limit.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionLimLow")]
  LimLow = 10,
  /// <summary>
  /// Equation upper limit.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionLimUpp")]
  LimUpp = 11,
  /// <summary>
  /// Equation matrix.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionMat")]
  Mat = 12,
  /// <summary>
  /// Equation N-ary operator.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionNary")]
  Nary = 13,
  /// <summary>
  /// Equation phantom.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionPhantom")]
  Phantom = 14,
  /// <summary>
  /// Scr pre.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionScrPre")]
  ScrPre = 15,
  /// <summary>
  /// Equation base expression.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionRad")]
  Rad = 16,
  /// <summary>
  /// Scr. sub.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionScrSub")]
  ScrSub = 17,
  /// <summary>
  /// Scr. sub sup.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionScrSubSup")]
  ScrSubSup = 18,
  /// <summary>
  /// Scr sup.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionScrSup")]
  ScrSup = 19,
  /// <summary>
  /// Equation text.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionText")]
  Text = 20,
  /// <summary>
  /// Equation normal text.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionNormalText")] 
  NormalText = 21,
  /// <summary>
  /// Equation literal text.
  /// </summary>
  [InteropEnumValue("wdOMathFunctionLiteralText")]
  LiteralText = 22
}
