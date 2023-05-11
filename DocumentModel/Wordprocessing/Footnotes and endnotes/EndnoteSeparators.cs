namespace DocumentModel.Wordprocessing;

/// <summary>
///   Collection of endnote separator references.
/// </summary>
public class EndnoteSeparators: ElementCollection<EndnoteSeparator>
{
  /// <summary>
  /// Creates default separators.
  /// </summary>
  public void Init()
  {
    Add(new EndnoteSeparator { Id = -1});
    Add(new EndnoteSeparator { Id = 0});
  }
}