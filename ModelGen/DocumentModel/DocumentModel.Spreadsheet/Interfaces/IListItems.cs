namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ListItems Class.
/// </summary>
public interface IListItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<System.String>? ListItems { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
