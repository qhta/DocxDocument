namespace DocumentModel.Spreadsheet;

/// <summary>
/// Dialog Sheet Views.
/// </summary>
public interface ISheetViews // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ISheetView>? SheetViews { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
