namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ListItems Class.
/// </summary>
public interface ListItems // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<String>? ListItems { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
