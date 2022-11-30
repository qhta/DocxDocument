namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ListItems Class.
/// </summary>
public interface IListItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<System.String>? ListItems { get ; set; }
  
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
