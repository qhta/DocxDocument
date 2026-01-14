namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of contributors (authors, editors, etc.).
/// </summary>
public interface Contributors: IElementCollection<Contributor>
{
  /// <summary>
  ///   Formats the contributors as a string according to bibliography style.
  /// </summary>
  /// <param name="style">The bibliography style to use for formatting.</param>
  /// <returns>Formatted contributor string.</returns>
  public string Format(string style);
}