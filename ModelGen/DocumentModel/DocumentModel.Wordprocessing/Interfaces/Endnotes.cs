namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Endnotes.
/// </summary>
public interface Endnotes // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Endnote>? Endnotes { get ; set; }
  
}
