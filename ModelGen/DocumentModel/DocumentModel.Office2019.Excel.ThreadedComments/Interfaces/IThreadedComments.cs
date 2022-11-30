namespace DocumentModel.Office2019.Excel.ThreadedComments;

/// <summary>
/// Defines the ThreadedComments Class.
/// </summary>
public interface IThreadedComments // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2019.Excel.ThreadedComments.IThreadedComment>? ThreadedComments { get ; set; }
  
  public DocumentModel.Office2019.Excel.ThreadedComments.IExtensionList? ExtensionList { get ; set; }
  
}
