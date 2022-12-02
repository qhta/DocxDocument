namespace DocumentModel.Spreadsheet;

/// <summary>
/// Rich Text Inline.
/// </summary>
public interface IInlineString // : DocumentModel.Spreadsheet.IRstType
{
  public IXstringType? Text { get ; set; }
  
  public Collection<IRun>? Runs { get ; set; }
  
  public Collection<IPhoneticRun>? PhoneticRuns { get ; set; }
  
  public IPhoneticProperties? PhoneticProperties { get ; set; }
  
}
