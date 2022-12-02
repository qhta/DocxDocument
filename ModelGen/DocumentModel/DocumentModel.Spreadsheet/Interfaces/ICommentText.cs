namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comment Text.
/// </summary>
public interface ICommentText // : DocumentModel.Spreadsheet.IRstType
{
  public IXstringType? Text { get ; set; }
  
  public Collection<IRun>? Runs { get ; set; }
  
  public Collection<IPhoneticRun>? PhoneticRuns { get ; set; }
  
  public IPhoneticProperties? PhoneticProperties { get ; set; }
  
}
