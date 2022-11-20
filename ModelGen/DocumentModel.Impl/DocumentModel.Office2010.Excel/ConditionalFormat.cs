namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormat Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotAreas))]
public class ConditionalFormat: IConditionalFormat
{
  /// <summary>
  /// scope, this property is only available in Office 2010 and later.
  /// </summary>
  public ScopeValues? Scope
  {
    get;
    set;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.RuleValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// priority, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Priority
  {
    get;
    set;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// PivotAreas.
  /// </summary>
  public DocumentModel.Office2010.Excel.IPivotAreas? PivotAreas
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
