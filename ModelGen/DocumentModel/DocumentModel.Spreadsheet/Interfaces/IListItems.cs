namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ListItems Class.
/// </summary>
public interface IListItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<String>? ListItems { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
