namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comment Text.
/// </summary>
public interface ICommentText // : DocumentModel.Spreadsheet.IRstType
{
  public DocumentModel.Spreadsheet.IXstringType? Text { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IRun>? Runs { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPhoneticRun>? PhoneticRuns { get ; set; }
  
  public DocumentModel.Spreadsheet.IPhoneticProperties? PhoneticProperties { get ; set; }
  
}
