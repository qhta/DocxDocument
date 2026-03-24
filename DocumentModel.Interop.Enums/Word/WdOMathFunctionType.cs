namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of equation function.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathfunctiontype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdOMathFunctionType
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
  /// Specifies the type of equation function.
  /// </summary>
  Mat = 12,
  /// <summary>
  /// Specifies the type of equation function.
  /// </summary>
  Nary = 13,
  /// <summary>
  /// Specifies the type of equation function.
  /// </summary>
  Phantom = 14,
  /// <summary>
  /// Specifies the type of equation function.
  /// </summary>
  ScrPre = 15,
  /// <summary>
  /// Specifies the type of equation function.
  /// </summary>
  Rad = 16,
  /// <summary>
  /// Specifies the type of equation function.
  /// </summary>
  ScrSub = 17,
  /// <summary>
  /// Specifies the type of equation function.
  /// </summary>
  ScrSubSup = 18,
  /// <summary>
  /// Specifies the type of equation function.
  /// </summary>
  ScrSup = 19,
  /// <summary>
  /// Specifies the type of equation function.
  /// </summary>
  Text = 20,
  /// <summary>
  /// Specifies the type of equation function.
  /// </summary>
  NormalText = 21,
  /// <summary>
  /// Specifies the type of equation function.
  /// </summary>
  LiteralText = 22
}
