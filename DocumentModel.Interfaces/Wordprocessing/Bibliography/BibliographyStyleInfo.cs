namespace DocumentModel.Wordprocessing;

/// <summary>
///   Provides information about a bibliography style.
/// </summary>
public interface BibliographyStyleInfo
{
  /// <summary>
  ///   Gets the internal name of the style.
  /// </summary>
  public string? Name { get; }

  /// <summary>
  ///   Gets the display name of the style.
  /// </summary>
  public string? DisplayName { get; }

  /// <summary>
  ///   Gets the description of the style.
  /// </summary>
  public string? Description { get; }

  /// <summary>
  ///   Gets the organization or authority that defines this style.
  /// </summary>
  public string? Authority { get; }

  /// <summary>
  ///   Gets the file path to the style definition (XSL file).
  /// </summary>
  public string? FilePath { get; }

  /// <summary>
  ///   Gets the version of the style.
  /// </summary>
  public string? Version { get; }

  /// <summary>
  ///   Gets whether this is a built-in style.
  /// </summary>
  public bool IsBuiltIn { get; }
}