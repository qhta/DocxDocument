namespace DocumentModel.Interop.Word;

public partial interface AutoCorrectEntries
{
  /// <summary>
  /// Adds an AutoCorrect entry to the list of available AutoCorrect entries.
  /// </summary>
  /// <param name="Name">The text to automatically replace.</param>
  /// <param name="Value">The replacement text.</param>
  /// <returns>The created <see cref="AutoCorrectEntry"/> object.</returns>
  public AutoCorrectEntry Add(string Name, string Value);

  /// <summary>
  /// Adds a formatted (rich-text) AutoCorrect entry.
  /// </summary>
  /// <param name="Name">The text to automatically replace.</param>
  /// <param name="Range">The range whose formatted content is stored as the replacement.</param>
  /// <returns>The created <see cref="AutoCorrectEntry"/> object.</returns>
  public AutoCorrectEntry AddRichText(string Name, Range Range);
}
