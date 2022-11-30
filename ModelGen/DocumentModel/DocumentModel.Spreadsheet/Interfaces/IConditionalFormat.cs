namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Formatting.
/// </summary>
public interface IConditionalFormat // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Conditional Formatting Scope
  /// </summary>
  public DocumentModel.Spreadsheet.ScopeKind? Scope { get ; set; }
  
  /// <summary>
  /// Conditional Formatting Rule Type
  /// </summary>
  public DocumentModel.Spreadsheet.RuleKind? Type { get ; set; }
  
  /// <summary>
  /// Priority
  /// </summary>
  public System.UInt32? Priority { get ; set; }
  
  /// <summary>
  /// Pivot Areas.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotAreas? PivotAreas { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
