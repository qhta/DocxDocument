namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ThreadedComments Class.
/// </summary>
public interface ThreadedComments // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ThreadedComment>? ThreadedComments { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
