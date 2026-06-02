namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of AutoCorrectEntry objects that represent all the AutoCorrect entries available to Microsoft Word. The AutoCorrectEntries collection includes all the entries in the AutoCorrect dialog box (Tools menu).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentries?view=word-pia"/>
public interface IAutoCorrectEntries : IInteropObject, IInteropCollection<AutoCorrectEntry>
{


  #region methods

/// <summary>
  /// Adds an AutoCorrect entry to the list of available AutoCorrect entries.
  /// </summary>
  /// <param name="Name">The text to automatically replace.</param>
  /// <param name="Value">The replacement text.</param>
  /// <returns>The created <see cref="AutoCorrectEntry"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentries.add?view=word-pia"/>
  public AutoCorrectEntry Add(string Name, string Value);

  /// <summary>
  /// Adds a formatted (rich-text) AutoCorrect entry.
  /// </summary>
  /// <param name="Name">The text to automatically replace.</param>
  /// <param name="Range">The range whose formatted content is stored as the replacement.</param>
  /// <returns>The created <see cref="AutoCorrectEntry"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentries.addrichtext?view=word-pia"/>
  public AutoCorrectEntry AddRichText(string Name, Range Range);

  #endregion methods
}
