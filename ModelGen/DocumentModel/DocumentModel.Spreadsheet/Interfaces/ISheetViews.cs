namespace DocumentModel.Spreadsheet;

/// <summary>
/// Dialog Sheet Views.
/// </summary>
public interface ISheetViews // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISheetView>? SheetViews { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
