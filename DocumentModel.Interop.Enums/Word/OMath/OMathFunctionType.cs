namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of equation function.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathfunctiontype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOMathFunctionType")]
public enum OMathFunctionType
{
  /// <summary>
  /// Equation accent mark.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionAcc")]
  Acc = 1,
  /// <summary>
  /// Equation fraction bar.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionBar")]
  Bar = 2,
  /// <summary>
  /// Box.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionBox")]
  Box = 3,
  /// <summary>
  /// Border box.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionBorderBox")]
  BorderBox = 4,
  /// <summary>
  /// Equation delimiters.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionDelim")]
  Delim = 5,
  /// <summary>
  /// Equation array.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionEqArray")]
  EqArray = 6,
  /// <summary>
  /// Equation fraction.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionFrac")]
  Frac = 7,
  /// <summary>
  /// Equation function.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionFunc")]
  Func = 8,
  /// <summary>
  /// Group character.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionGroupChar")]
  GroupChar = 9,
  /// <summary>
  /// Equation lower limit.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionLimLow")]
  LimLow = 10,
  /// <summary>
  /// Equation upper limit.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionLimUpp")]
  LimUpp = 11,
  /// <summary>
  /// Equation matrix.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionMat")]
  Mat = 12,
  /// <summary>
  /// Equation N-ary operator.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionNary")]
  Nary = 13,
  /// <summary>
  /// Equation phantom.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionPhantom")]
  Phantom = 14,
  /// <summary>
  /// Scr pre.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionScrPre")]
  ScrPre = 15,
  /// <summary>
  /// Equation base expression.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionRad")]
  Rad = 16,
  /// <summary>
  /// Scr. sub.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionScrSub")]
  ScrSub = 17,
  /// <summary>
  /// Scr. sub sup.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionScrSubSup")]
  ScrSubSup = 18,
  /// <summary>
  /// Scr sup.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionScrSup")]
  ScrSup = 19,
  /// <summary>
  /// Equation text.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionText")]
  Text = 20,
  /// <summary>
  /// Equation normal text.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionNormalText")] 
  NormalText = 21,
  /// <summary>
  /// Equation literal text.
  /// </summary>
  [WordInteropEnumValue("wdOMathFunctionLiteralText")]
  LiteralText = 22
}
