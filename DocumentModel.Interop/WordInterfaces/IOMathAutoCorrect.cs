namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the math AutoCorrect feature in Microsoft Office Word. To access the math AutoCorrect entries, use the OMathAutoCorrectEntries collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect?view=word-pia"/>
public interface IOMathAutoCorrect : IInteropObject
{
  /// <summary>
  /// Returns or sets whether text is replaced with math AutoCorrect entries as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.replacetext?view=word-pia"/>
  public bool ReplaceText { get; set; }
  /// <summary>
  /// Returns or sets whether math AutoCorrect rules are used outside equation regions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.useoutsideomath?view=word-pia"/>
  public bool UseOutsideOMath { get; set; }
  /// <summary>
  /// Returns the collection of math AutoCorrect entries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.entries?view=word-pia"/>
  public OMathAutoCorrectEntries Entries { get; }
  /// <summary>
  /// Returns the collection of recognized math functions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.functions?view=word-pia"/>
  public OMathRecognizedFunctions Functions { get; }

}
