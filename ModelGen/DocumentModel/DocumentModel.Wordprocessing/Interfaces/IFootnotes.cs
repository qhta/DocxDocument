namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Footnotes.
/// </summary>
public interface IFootnotes // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public DocumentModel.Wordprocessing.IFootnote? Footnote { get ; set; }
  
}
