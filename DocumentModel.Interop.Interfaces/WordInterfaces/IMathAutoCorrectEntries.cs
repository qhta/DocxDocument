namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of math AutoCorrect entries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentries?view=word-pia"/>
public interface IMathAutoCorrectEntries : IInteropObject, IInteropCollection<IMathAutoCorrectEntry>
{


  #region methods

/// <summary>
  /// Adds a math AutoCorrect entry to the collection.
  /// </summary>
  /// <param name="name">Specifies the text to replace.</param>
  /// <param name="value">Specifies the replacement text.</param>
  /// <returns>The added math AutoCorrect entry.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentries.add?view=word-pia"/>
  public IMathAutoCorrectEntry Add(string name, string value);

  #endregion methods
}

