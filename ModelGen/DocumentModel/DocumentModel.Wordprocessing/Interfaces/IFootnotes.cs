namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Footnotes.
/// </summary>
public interface IFootnotes // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the FootnotesPart associated with this element.
  /// </summary>
  public IFootnotesPart? FootnotesPart { get ; set; }
  
}
