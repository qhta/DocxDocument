namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of number.
/// </summary>
public enum WdNumberType
{
  /// <summary>
  /// Preset numbers you can add to paragraphs by selecting a template in the Bullets and Numbering dialog box.
  /// wdNumberListNum2 Default value for LISTNUM fields. wdNumberAllNumbers3 Default value for all other cases.
  /// </summary>
  wdNumberParagraph = unchecked((int)1),
  /// <summary>
  /// Specifies the type of number.
  /// </summary>
  wdNumberListNum = unchecked((int)2),
  /// <summary>
  /// Specifies the type of number.
  /// </summary>
  wdNumberAllNumbers = unchecked((int)3)
}
