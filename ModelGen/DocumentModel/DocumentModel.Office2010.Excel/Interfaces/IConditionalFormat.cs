namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormat Class.
/// </summary>
public interface IConditionalFormat // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// scope, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.ScopeKind? Scope { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.RuleKind? Type { get ; set; }
  
  /// <summary>
  /// priority, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Priority { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// PivotAreas.
  /// </summary>
  public DocumentModel.Office2010.Excel.IPivotAreas? PivotAreas { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
