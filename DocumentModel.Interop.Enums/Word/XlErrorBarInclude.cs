namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which error-bar parts to include.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlerrorbarinclude?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlErrorBarInclude))]
public enum ErrorBarInclude
{
  /// <summary>
  /// Both positive and negative error range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlErrorBarInclude.xlErrorBarIncludeBoth))]
  Both = 1,
  /// <summary>
  /// Only positive error range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlErrorBarInclude.xlErrorBarIncludePlusValues))]
  PlusValues = 2,
  /// <summary>
  /// Only negative error range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlErrorBarInclude.xlErrorBarIncludeMinusValues))]
  MinusValues = 3,
  /// <summary>
  /// No error bar range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlErrorBarInclude.xlErrorBarIncludeNone))]
  None = -4142
}
