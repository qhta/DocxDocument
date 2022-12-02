namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormat Class.
/// </summary>
public interface IConditionalFormat // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// scope, this property is only available in Office 2010 and later.
  /// </summary>
  public ScopeKind? Scope { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public RuleKind? Type { get ; set; }
  
  /// <summary>
  /// priority, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? Priority { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// PivotAreas.
  /// </summary>
  public IPivotAreas? PivotAreas { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
