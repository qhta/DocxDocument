namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Footnotes.
/// </summary>
public interface Footnotes
{
  public Collection<Footnote>? Items { get ; set; }
  
}
