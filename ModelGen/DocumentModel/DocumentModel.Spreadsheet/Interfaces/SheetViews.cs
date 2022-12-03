namespace DocumentModel.Spreadsheet;

/// <summary>
/// Dialog Sheet Views.
/// </summary>
public interface SheetViews // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<SheetView>? SheetViews { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
