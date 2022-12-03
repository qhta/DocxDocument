namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the NamedSheetView Class.
/// </summary>
public interface NamedSheetView // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  public Collection<NsvFilter>? NsvFilters { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
