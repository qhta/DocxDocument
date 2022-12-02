namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SortRules Class.
/// </summary>
public interface ISortRules // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// sortMethod, this property is only available in Office 2021 and later.
  /// </summary>
  public SortMethodKind? SortMethod { get ; set; }
  
  /// <summary>
  /// caseSensitive, this property is only available in Office 2021 and later.
  /// </summary>
  public Boolean? CaseSensitive { get ; set; }
  
  public Collection<ISortRule>? SortRules { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
