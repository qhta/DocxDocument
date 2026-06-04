namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the display unit label for an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldisplayunit?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlDisplayUnit))]
public enum DisplayUnit
{
  /// <summary>
  /// Millions of millions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayUnit.xlMillionMillions))]
  MillionMillions = -10,
  /// <summary>
  /// Thousands of millions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayUnit.xlThousandMillions))]
  ThousandMillions = -9,
  /// <summary>
  /// Hundreds of millions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayUnit.xlHundredMillions))]
  HundredMillions = -8,
  /// <summary>
  /// Tens of millions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayUnit.xlTenMillions))]
  TenMillions = -7,
  /// <summary>
  /// Millions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayUnit.xlMillions))]
  Millions = -6,
  /// <summary>
  /// Hundreds of thousands.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayUnit.xlHundredThousands))]
  HundredThousands = -5,
  /// <summary>
  /// Tens of thousands.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayUnit.xlTenThousands))]
  TenThousands = -4,
  /// <summary>
  /// Thousands.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayUnit.xlThousands))]
  Thousands = -3,
  /// <summary>
  /// Hundreds.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayUnit.xlHundreds))]
  Hundreds = -2
}
