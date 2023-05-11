namespace DocumentModel.Wordprocessing;

/// <summary>
///   Collection of footnote separator references.
/// </summary>
public class FootnoteSeparators: ElementCollection<FootnoteSeparator>
{
  /// <summary>
  /// Creates default separators.
  /// </summary>
  public void Init()
  {
    Add(new FootnoteSeparator { Id = -1});
    Add(new FootnoteSeparator { Id = 0});
  }
}