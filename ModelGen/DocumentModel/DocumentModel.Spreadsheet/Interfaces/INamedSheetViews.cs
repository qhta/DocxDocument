namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the NamedSheetViews Class.
/// </summary>
public interface INamedSheetViews // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.INamedSheetView>? NamedSheetViews { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
