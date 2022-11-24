namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Endnotes.
/// </summary>
public interface IEndnotes // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the EndnotesPart associated with this element.
  /// </summary>
  public IEndnotesPart? EndnotesPart { get ; set; }
  
}
