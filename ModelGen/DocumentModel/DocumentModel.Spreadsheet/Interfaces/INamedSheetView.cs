namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the NamedSheetView Class.
/// </summary>
public interface INamedSheetView // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  public Collection<INsvFilter>? NsvFilters { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
