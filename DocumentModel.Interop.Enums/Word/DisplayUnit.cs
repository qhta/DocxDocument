namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the display unit label for an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldisplayunit?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlDisplayUnit")]
public enum DisplayUnit
{
  /// <summary>
  /// Millions of millions.
  /// </summary>
  [InteropEnumValue("xlMillionMillions")]
  MillionMillions = -10,
  /// <summary>
  /// Thousands of millions.
  /// </summary>
  [InteropEnumValue("xlThousandMillions")]
  ThousandMillions = -9,
  /// <summary>
  /// Hundreds of millions.
  /// </summary>
  [InteropEnumValue("xlHundredMillions")]
  HundredMillions = -8,
  /// <summary>
  /// Tens of millions.
  /// </summary>
  [InteropEnumValue("xlTenMillions")]
  TenMillions = -7,
  /// <summary>
  /// Millions.
  /// </summary>
  [InteropEnumValue("xlMillions")]
  Millions = -6,
  /// <summary>
  /// Hundreds of thousands.
  /// </summary>
  [InteropEnumValue("xlHundredThousands")]
  HundredThousands = -5,
  /// <summary>
  /// Tens of thousands.
  /// </summary>
  [InteropEnumValue("xlTenThousands")]
  TenThousands = -4,
  /// <summary>
  /// Thousands.
  /// </summary>
  [InteropEnumValue("xlThousands")]
  Thousands = -3,
  /// <summary>
  /// Hundreds.
  /// </summary>
  [InteropEnumValue("xlHundreds")]
  Hundreds = -2
}

