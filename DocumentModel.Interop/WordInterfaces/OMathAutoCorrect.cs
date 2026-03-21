namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the math AutoCorrect feature in Microsoft Office Word. To access the math AutoCorrect entries, use the OMathAutoCorrectEntries collection.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect?view=word-pia"/>
public interface OMathAutoCorrect : InteropObject
{
  /// <summary>
  /// The replace text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.replacetext?view=word-pia"/>
  public bool ReplaceText { get; set; }
  /// <summary>
  /// The use outside omath.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.useoutsideomath?view=word-pia"/>
  public bool UseOutsideOMath { get; set; }
  /// <summary>
  /// The entries.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.entries?view=word-pia"/>
  public OMathAutoCorrectEntries Entries { get; }
  /// <summary>
  /// The functions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrect.functions?view=word-pia"/>
  public OMathRecognizedFunctions Functions { get; }

}
