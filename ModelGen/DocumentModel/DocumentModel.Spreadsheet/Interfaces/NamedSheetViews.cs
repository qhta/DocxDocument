namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the NamedSheetViews Class.
/// </summary>
public interface NamedSheetViews // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<NamedSheetView>? NamedSheetViews { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
