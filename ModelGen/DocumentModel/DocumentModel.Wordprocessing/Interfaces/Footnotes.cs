namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Footnotes.
/// </summary>
public interface Footnotes // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Footnote>? Footnotes { get ; set; }
  
}
