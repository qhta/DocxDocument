namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the AutoCorrect functionality in Microsoft Word.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect?view=word-pia"/>
public interface IAutoCorrect : IModelObject
{
  /// <summary>
  /// Gets or sets a value indicating whether day names are corrected automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correctdays?view=word-pia"/>
  public bool CorrectDays { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets a value indicating whether accidental initial capitals are corrected.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correctinitialcaps?view=word-pia"/>
  public bool CorrectInitialCaps { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets a value indicating whether sentence capitalization is corrected automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correctsentencecaps?view=word-pia"/>
  public bool CorrectSentenceCaps { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets a value indicating whether text is replaced using AutoCorrect entries.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.replacetext?view=word-pia"/>
  public bool ReplaceText { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the AutoCorrect entries collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.entries?view=word-pia"/>
  public IAutoCorrectEntries Entries { get; }
  /// <summary>
  /// Gets the first-letter exceptions collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.firstletterexceptions?view=word-pia"/>
  public IFirstLetterExceptions FirstLetterExceptions { get; }
  /// <summary>
  /// Gets or sets a value indicating whether first-letter exceptions are added automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.firstletterautoadd?view=word-pia"/>
  public bool FirstLetterAutoAdd { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the two-initial-capitals exceptions collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.twoinitialcapsexceptions?view=word-pia"/>
  public ITwoInitialCapsExceptions TwoInitialCapsExceptions { get; }
  /// <summary>
  /// Gets or sets a value indicating whether two-initial-capitals exceptions are added automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.twoinitialcapsautoadd?view=word-pia"/>
  public bool TwoInitialCapsAutoAdd { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets a value indicating whether accidental CAPS LOCK usage is corrected.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correctcapslock?view=word-pia"/>
  public bool CorrectCapsLock { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets a value indicating whether Hangul and alphabet input is corrected.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correcthangulandalphabet?view=word-pia"/>
  public bool CorrectHangulAndAlphabet { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the Hangul-and-alphabet exceptions collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.hangulandalphabetexceptions?view=word-pia"/>
  public IHangulAndAlphabetExceptions HangulAndAlphabetExceptions { get; }
  /// <summary>
  /// Gets or sets a value indicating whether Hangul-and-alphabet exceptions are added automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.hangulandalphabetautoadd?view=word-pia"/>
  public bool HangulAndAlphabetAutoAdd { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets a value indicating whether text from the spelling checker is added to AutoCorrect.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.replacetextfromspellingchecker?view=word-pia"/>
  public bool ReplaceTextFromSpellingChecker { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets a value indicating whether other correction exceptions are added automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.othercorrectionsautoadd?view=word-pia"/>
  public bool OtherCorrectionsAutoAdd { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the other-corrections exceptions collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.othercorrectionsexceptions?view=word-pia"/>
  public IOtherCorrectionsExceptions OtherCorrectionsExceptions { get; }
  /// <summary>
  /// Gets or sets a value indicating whether keyboard setting mismatches are corrected.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correctkeyboardsetting?view=word-pia"/>
  public bool CorrectKeyboardSetting { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets a value indicating whether AutoCorrect options are applied in table cells.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.correcttablecells?view=word-pia"/>
  public bool CorrectTableCells { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets a value indicating whether AutoCorrect option buttons are displayed.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrect.displayautocorrectoptions?view=word-pia"/>
  public bool DisplayAutoCorrectOptions { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}
