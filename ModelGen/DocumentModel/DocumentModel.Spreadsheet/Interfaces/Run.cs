namespace DocumentModel.Spreadsheet;

/// <summary>
/// Rich Text Run.
/// </summary>
public interface Run // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public RunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public XstringType? Text { get ; set; }
  
}
