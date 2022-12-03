namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SortRules Class.
/// </summary>
public interface SortRules // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// sortMethod, this property is only available in Office 2021 and later.
  /// </summary>
  public SortMethodKind? SortMethod { get ; set; }
  
  /// <summary>
  /// caseSensitive, this property is only available in Office 2021 and later.
  /// </summary>
  public Boolean? CaseSensitive { get ; set; }
  
  public Collection<SortRule>? SortRules { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
