namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ThreadedComments Class.
/// </summary>
public interface IThreadedComments // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IThreadedComment>? ThreadedComments { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
