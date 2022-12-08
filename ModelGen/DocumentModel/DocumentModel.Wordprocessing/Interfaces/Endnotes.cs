namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Endnotes.
/// </summary>
public interface Endnotes
{
  public Collection<Endnote>? Items { get ; set; }
  
}
