namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the NamedSheetView Class.
/// </summary>
public interface INamedSheetView // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.INsvFilter>? NsvFilters { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
