namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Footnotes.
/// </summary>
public interface IFootnotes // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<IFootnote>? Footnotes { get ; set; }
  
}
