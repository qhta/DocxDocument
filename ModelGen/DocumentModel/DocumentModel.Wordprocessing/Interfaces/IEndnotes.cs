namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Endnotes.
/// </summary>
public interface IEndnotes // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public DocumentModel.Wordprocessing.IEndnote? Endnote { get ; set; }
  
}
