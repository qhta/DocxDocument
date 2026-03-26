namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the display unit label for an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldisplayunit?view=office-pia` for Office interop details.
/// </remarks>
public enum DisplayUnit
{
  /// <summary>
  /// Millions of millions.
  /// </summary>
  MillionMillions = -10,
  /// <summary>
  /// Thousands of millions.
  /// </summary>
  ThousandMillions = -9,
  /// <summary>
  /// Hundreds of millions.
  /// </summary>
  HundredMillions = -8,
  /// <summary>
  /// Tens of millions.
  /// </summary>
  TenMillions = -7,
  /// <summary>
  /// Millions.
  /// </summary>
  Millions = -6,
  /// <summary>
  /// Hundreds of thousands.
  /// </summary>
  HundredThousands = -5,
  /// <summary>
  /// Tens of thousands.
  /// </summary>
  TenThousands = -4,
  /// <summary>
  /// Thousands.
  /// </summary>
  Thousands = -3,
  /// <summary>
  /// Hundreds.
  /// </summary>
  Hundreds = -2
}
