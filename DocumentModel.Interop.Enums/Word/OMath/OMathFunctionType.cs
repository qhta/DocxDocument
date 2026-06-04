namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of equation function.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathfunctiontype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOMathFunctionType))]
public enum OMathFunctionType
{
  /// <summary>
  /// Equation accent mark.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionAcc))]
  Acc = 1,
  /// <summary>
  /// Equation fraction bar.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionBar))]
  Bar = 2,
  /// <summary>
  /// Box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionBox))]
  Box = 3,
  /// <summary>
  /// Border box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionBorderBox))]
  BorderBox = 4,
  /// <summary>
  /// Equation delimiters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionDelim))]
  Delim = 5,
  /// <summary>
  /// Equation array.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionEqArray))]
  EqArray = 6,
  /// <summary>
  /// Equation fraction.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionFrac))]
  Frac = 7,
  /// <summary>
  /// Equation function.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionFunc))]
  Func = 8,
  /// <summary>
  /// Group character.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionGroupChar))]
  GroupChar = 9,
  /// <summary>
  /// Equation lower limit.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionLimLow))]
  LimLow = 10,
  /// <summary>
  /// Equation upper limit.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionLimUpp))]
  LimUpp = 11,
  /// <summary>
  /// Equation matrix.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionMat))]
  Mat = 12,
  /// <summary>
  /// Equation N-ary operator.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionNary))]
  Nary = 13,
  /// <summary>
  /// Equation phantom.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionPhantom))]
  Phantom = 14,
  /// <summary>
  /// Scr pre.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionScrPre))]
  ScrPre = 15,
  /// <summary>
  /// Equation base expression.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionRad))]
  Rad = 16,
  /// <summary>
  /// Scr. sub.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionScrSub))]
  ScrSub = 17,
  /// <summary>
  /// Scr. sub sup.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionScrSubSup))]
  ScrSubSup = 18,
  /// <summary>
  /// Scr sup.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionScrSup))]
  ScrSup = 19,
  /// <summary>
  /// Equation text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionText))]
  Text = 20,
  /// <summary>
  /// Equation normal text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionNormalText))] 
  NormalText = 21,
  /// <summary>
  /// Equation literal text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathFunctionType.wdOMathFunctionLiteralText))]
  LiteralText = 22
}
