namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single contributor (author, editor, etc.).
/// </summary>
public interface Contributor: CollectionItem
{
  /// <summary>
  ///   Gets or sets the first name.
  /// </summary>
  public string? First { get; set; }

  /// <summary>
  ///   Gets or sets the middle name or initial.
  /// </summary>
  public string? Middle { get; set; }

  /// <summary>
  ///   Gets or sets the last name (surname).
  /// </summary>
  public string? Last { get; set; }

  /// <summary>
  ///   Gets or sets the name suffix (Jr., Sr., III, etc.).
  /// </summary>
  public string? Suffix { get; set; }

  /// <summary>
  ///   Gets or sets the corporate or organizational name.
  /// </summary>
  public string? Corporate { get; set; }

  /// <summary>
  ///   Gets whether this is a corporate contributor.
  /// </summary>
  public bool IsCorporate { get; }

  /// <summary>
  ///   Gets the full name formatted according to style.
  /// </summary>
  /// <param name="style">The bibliography style for formatting.</param>
  /// <returns>Formatted full name.</returns>
  public string GetFormattedName(string style);
}