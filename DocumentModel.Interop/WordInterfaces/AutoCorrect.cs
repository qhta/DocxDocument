namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the AutoCorrect functionality in Microsoft Word.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect?view=word-pia"/>
public interface AutoCorrect : InteropObject
{
  /// <summary>
  /// The correct days.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correctdays?view=word-pia"/>
  public bool CorrectDays { get; set; }
  /// <summary>
  /// The correct initial caps.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correctinitialcaps?view=word-pia"/>
  public bool CorrectInitialCaps { get; set; }
  /// <summary>
  /// The correct sentence caps.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correctsentencecaps?view=word-pia"/>
  public bool CorrectSentenceCaps { get; set; }
  /// <summary>
  /// The replace text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.replacetext?view=word-pia"/>
  public bool ReplaceText { get; set; }
  /// <summary>
  /// The entries.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.entries?view=word-pia"/>
  public AutoCorrectEntries Entries { get; }
  /// <summary>
  /// The first letter exceptions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.firstletterexceptions?view=word-pia"/>
  public FirstLetterExceptions FirstLetterExceptions { get; }
  /// <summary>
  /// The first letter auto add.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.firstletterautoadd?view=word-pia"/>
  public bool FirstLetterAutoAdd { get; set; }
  /// <summary>
  /// The two initial caps exceptions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.twoinitialcapsexceptions?view=word-pia"/>
  public TwoInitialCapsExceptions TwoInitialCapsExceptions { get; }
  /// <summary>
  /// The two initial caps auto add.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.twoinitialcapsautoadd?view=word-pia"/>
  public bool TwoInitialCapsAutoAdd { get; set; }
  /// <summary>
  /// The correct caps lock.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correctcapslock?view=word-pia"/>
  public bool CorrectCapsLock { get; set; }
  /// <summary>
  /// The correct hangul and alphabet.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correcthangulandalphabet?view=word-pia"/>
  public bool CorrectHangulAndAlphabet { get; set; }
  /// <summary>
  /// The hangul and alphabet exceptions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.hangulandalphabetexceptions?view=word-pia"/>
  public HangulAndAlphabetExceptions HangulAndAlphabetExceptions { get; }
  /// <summary>
  /// The hangul and alphabet auto add.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.hangulandalphabetautoadd?view=word-pia"/>
  public bool HangulAndAlphabetAutoAdd { get; set; }
  /// <summary>
  /// The replace text from spelling checker.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.replacetextfromspellingchecker?view=word-pia"/>
  public bool ReplaceTextFromSpellingChecker { get; set; }
  /// <summary>
  /// The other corrections auto add.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.othercorrectionsautoadd?view=word-pia"/>
  public bool OtherCorrectionsAutoAdd { get; set; }
  /// <summary>
  /// The other corrections exceptions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.othercorrectionsexceptions?view=word-pia"/>
  public OtherCorrectionsExceptions OtherCorrectionsExceptions { get; }
  /// <summary>
  /// The correct keyboard setting.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correctkeyboardsetting?view=word-pia"/>
  public bool CorrectKeyboardSetting { get; set; }
  /// <summary>
  /// The correct table cells.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correcttablecells?view=word-pia"/>
  public bool CorrectTableCells { get; set; }
  /// <summary>
  /// The display auto correct options.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.displayautocorrectoptions?view=word-pia"/>
  public bool DisplayAutoCorrectOptions { get; set; }

}
