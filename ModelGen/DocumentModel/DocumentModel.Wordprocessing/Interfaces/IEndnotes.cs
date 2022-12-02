namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Endnotes.
/// </summary>
public interface IEndnotes // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<IEndnote>? Endnotes { get ; set; }
  
}
