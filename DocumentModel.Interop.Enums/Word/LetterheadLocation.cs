namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a location to place letterhead in a letter created by the Letter Wizard.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdletterheadlocation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdLetterheadLocation))]
public enum LetterheadLocation
{
  /// <summary>
  /// At the top of the letter.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLetterheadLocation.wdLetterTop))]
  Top = 0,
  /// <summary>
  /// At the bottom of the letter.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLetterheadLocation.wdLetterBottom))]
  Bottom = 1,
  /// <summary>
  /// To the left of the letter.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLetterheadLocation.wdLetterLeft))]
  Left = 2,
  /// <summary>
  /// To the right of the letter.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLetterheadLocation.wdLetterRight))]
  Right = 3
}
