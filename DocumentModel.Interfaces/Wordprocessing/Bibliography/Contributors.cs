namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of contributors (authors, editors, etc.).
/// </summary>
public interface Contributors : ElementCollection<Contributor>
{
  /// <summary>
  ///   Adds a contributor to the collection.
  /// </summary>
  /// <param name="contributor">The contributor to add.</param>
  public void Add(Contributor contributor);

  /// <summary>
  ///   Formats the contributors as a string according to bibliography style.
  /// </summary>
  /// <param name="style">The bibliography style to use for formatting.</param>
  /// <returns>Formatted contributor string.</returns>
  public string Format(string style);
}