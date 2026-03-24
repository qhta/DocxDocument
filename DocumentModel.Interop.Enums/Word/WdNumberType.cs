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
  /// Preset numbers you can add to paragraphs by selecting a template in the Bullets and Numbering dialog box.
  /// wdNumberListNum2 Default value for LISTNUM fields. wdNumberAllNumbers3 Default value for all other cases.
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
