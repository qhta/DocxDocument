namespace DocumentModel.Spreadsheet;

/// <summary>
/// Rich Text Inline.
/// </summary>
public interface IInlineString // : DocumentModel.Spreadsheet.IRstType
{
  public DocumentModel.Spreadsheet.IXstringType? Text { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IRun>? Runs { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPhoneticRun>? PhoneticRuns { get ; set; }
  
  public DocumentModel.Spreadsheet.IPhoneticProperties? PhoneticProperties { get ; set; }
  
}
