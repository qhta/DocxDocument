namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the display unit label for an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldisplayunit?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlDisplayUnit")]
public enum DisplayUnit
{
  /// <summary>
  /// Millions of millions.
  /// </summary>
  [WordInteropEnumValue("xlMillionMillions")]
  MillionMillions = -10,
  /// <summary>
  /// Thousands of millions.
  /// </summary>
  [WordInteropEnumValue("xlThousandMillions")]
  ThousandMillions = -9,
  /// <summary>
  /// Hundreds of millions.
  /// </summary>
  [WordInteropEnumValue("xlHundredMillions")]
  HundredMillions = -8,
  /// <summary>
  /// Tens of millions.
  /// </summary>
  [WordInteropEnumValue("xlTenMillions")]
  TenMillions = -7,
  /// <summary>
  /// Millions.
  /// </summary>
  [WordInteropEnumValue("xlMillions")]
  Millions = -6,
  /// <summary>
  /// Hundreds of thousands.
  /// </summary>
  [WordInteropEnumValue("xlHundredThousands")]
  HundredThousands = -5,
  /// <summary>
  /// Tens of thousands.
  /// </summary>
  [WordInteropEnumValue("xlTenThousands")]
  TenThousands = -4,
  /// <summary>
  /// Thousands.
  /// </summary>
  [WordInteropEnumValue("xlThousands")]
  Thousands = -3,
  /// <summary>
  /// Hundreds.
  /// </summary>
  [WordInteropEnumValue("xlHundreds")]
  Hundreds = -2
}
