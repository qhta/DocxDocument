namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of math AutoCorrect entries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentries?view=word-pia"/>
public partial interface IOMathAutoCorrectEntries : IInteropObject, IInteropCollection<OMathAutoCorrectEntry>
{


  #region methods

/// <summary>
  /// Adds a math AutoCorrect entry to the collection.
  /// </summary>
  /// <param name="Name">Specifies the text to replace.</param>
  /// <param name="Value">Specifies the replacement text.</param>
  /// <returns>The added math AutoCorrect entry.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentries.add?view=word-pia"/>
  public OMathAutoCorrectEntry Add(string Name, string Value);

  #endregion methods
}
