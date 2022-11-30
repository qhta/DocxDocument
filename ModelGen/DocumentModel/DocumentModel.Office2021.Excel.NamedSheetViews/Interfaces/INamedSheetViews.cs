namespace DocumentModel.Office2021.Excel.NamedSheetViews;

/// <summary>
/// Defines the NamedSheetViews Class.
/// </summary>
public interface INamedSheetViews // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2021.Excel.NamedSheetViews.INamedSheetView>? NamedSheetViews { get ; set; }
  
  public DocumentModel.Office2021.Excel.NamedSheetViews.IExtensionList? ExtensionList { get ; set; }
  
}
