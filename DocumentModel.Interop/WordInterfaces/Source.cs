namespace DocumentModel.Interop;

/// <summary>
/// Represents an individual source, such as a book, journal article, or interview.
/// </summary>
public partial interface Source : InteropObject
{
  /// <summary>
  /// The tag.
  /// </summary>
  public string Tag { get; }

  /// <summary>
  /// The xml.
  /// </summary>
  public string XML { get; }

  /// <summary>
  /// The cited.
  /// </summary>
  public bool Cited { get; }
}
