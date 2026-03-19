namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the AutoCorrect functionality in Microsoft Word.
/// </summary>
public interface AutoCorrect : InteropObject
{
  /// <summary>
  /// The correct days.
  /// </summary>
  public bool CorrectDays { get; set; }
  /// <summary>
  /// The correct initial caps.
  /// </summary>
  public bool CorrectInitialCaps { get; set; }
  /// <summary>
  /// The correct sentence caps.
  /// </summary>
  public bool CorrectSentenceCaps { get; set; }
  /// <summary>
  /// The replace text.
  /// </summary>
  public bool ReplaceText { get; set; }
  /// <summary>
  /// The entries.
  /// </summary>
  public AutoCorrectEntries Entries { get; }
  /// <summary>
  /// The first letter exceptions.
  /// </summary>
  public FirstLetterExceptions FirstLetterExceptions { get; }
  /// <summary>
  /// The first letter auto add.
  /// </summary>
  public bool FirstLetterAutoAdd { get; set; }
  /// <summary>
  /// The two initial caps exceptions.
  /// </summary>
  public TwoInitialCapsExceptions TwoInitialCapsExceptions { get; }
  /// <summary>
  /// The two initial caps auto add.
  /// </summary>
  public bool TwoInitialCapsAutoAdd { get; set; }
  /// <summary>
  /// The correct caps lock.
  /// </summary>
  public bool CorrectCapsLock { get; set; }
  /// <summary>
  /// The correct hangul and alphabet.
  /// </summary>
  public bool CorrectHangulAndAlphabet { get; set; }
  /// <summary>
  /// The hangul and alphabet exceptions.
  /// </summary>
  public HangulAndAlphabetExceptions HangulAndAlphabetExceptions { get; }
  /// <summary>
  /// The hangul and alphabet auto add.
  /// </summary>
  public bool HangulAndAlphabetAutoAdd { get; set; }
  /// <summary>
  /// The replace text from spelling checker.
  /// </summary>
  public bool ReplaceTextFromSpellingChecker { get; set; }
  /// <summary>
  /// The other corrections auto add.
  /// </summary>
  public bool OtherCorrectionsAutoAdd { get; set; }
  /// <summary>
  /// The other corrections exceptions.
  /// </summary>
  public OtherCorrectionsExceptions OtherCorrectionsExceptions { get; }
  /// <summary>
  /// The correct keyboard setting.
  /// </summary>
  public bool CorrectKeyboardSetting { get; set; }
  /// <summary>
  /// The correct table cells.
  /// </summary>
  public bool CorrectTableCells { get; set; }
  /// <summary>
  /// The display auto correct options.
  /// </summary>
  public bool DisplayAutoCorrectOptions { get; set; }

}
