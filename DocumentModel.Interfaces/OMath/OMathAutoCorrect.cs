namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the math AutoCorrect feature in Microsoft Office Word. To access the math AutoCorrect entries, use the OMathAutoCorrectEntries collection.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect?view=word-pia"/>
public interface IOMathAutoCorrect : IModelObject
{
  /// <summary>
  /// Returns or sets whether text is replaced with math AutoCorrect entries as you type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.replacetext?view=word-pia"/>
  public bool ReplaceText { get; set; }
  /// <summary>
  /// Returns or sets whether math AutoCorrect rules are used outside equation regions.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.useoutsideomath?view=word-pia"/>
  public bool UseOutsideOMath { get; set; }
  /// <summary>
  /// Returns the collection of math AutoCorrect entries.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.entries?view=word-pia"/>
  public IOMathAutoCorrectEntries Entries { get; }
  /// <summary>
  /// Returns the collection of recognized math functions.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.functions?view=word-pia"/>
  public IOMathRecognizedFunctions Functions { get; }

}
