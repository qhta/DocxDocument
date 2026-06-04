namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of number.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnumbertype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdNumberType))]
public enum NumberType
{
  /// <summary>
  /// Preset numbers you can add to paragraphs by selecting a template in the Bullets and Numbering dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNumberType.wdNumberParagraph))]
  Paragraph = 1,
  /// <summary>
  /// Default value for LISTNUM fields.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNumberType.wdNumberListNum))]
  ListNum = 2,
  /// <summary>
  /// Default value for all other cases.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNumberType.wdNumberAllNumbers))]
  AllNumbers = 3
}
