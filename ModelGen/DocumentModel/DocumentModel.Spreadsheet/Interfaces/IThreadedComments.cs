namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ThreadedComments Class.
/// </summary>
public interface IThreadedComments // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<IThreadedComment>? ThreadedComments { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
