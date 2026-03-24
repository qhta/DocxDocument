namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of number.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnumbertype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdNumberType
{
  /// <summary>
  /// Specifies the type of number.
  /// </summary>
  Paragraph = 1,
  /// <summary>
  /// Specifies the type of number.
  /// </summary>
  ListNum = 2,
  /// <summary>
  /// Specifies the type of number.
  /// </summary>
  AllNumbers = 3
}
