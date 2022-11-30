namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Sheet Views.
/// </summary>
public interface ICustomSheetViews // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICustomSheetView>? CustomSheetViews { get ; set; }
  
}
