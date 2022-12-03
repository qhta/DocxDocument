namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comment Text.
/// </summary>
public interface CommentText // : DocumentModel.Spreadsheet.RstType
{
  public XstringType? Text { get ; set; }
  
  public Collection<Run>? Runs { get ; set; }
  
  public Collection<PhoneticRun>? PhoneticRuns { get ; set; }
  
  public PhoneticProperties? PhoneticProperties { get ; set; }
  
}
