namespace DocumentModel.Spreadsheet;

/// <summary>
/// Rich Text Inline.
/// </summary>
public interface InlineString // : DocumentModel.Spreadsheet.RstType
{
  public XstringType? Text { get ; set; }
  
  public Collection<Run>? Runs { get ; set; }
  
  public Collection<PhoneticRun>? PhoneticRuns { get ; set; }
  
  public PhoneticProperties? PhoneticProperties { get ; set; }
  
}
