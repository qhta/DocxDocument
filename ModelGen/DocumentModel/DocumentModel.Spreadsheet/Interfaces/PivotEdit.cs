namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotEdit Class.
/// </summary>
public interface PivotEdit // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// PivotUserEdit.
  /// </summary>
  public PivotUserEdit? PivotUserEdit { get ; set; }
  
  /// <summary>
  /// TupleItems.
  /// </summary>
  public TupleItems? TupleItems { get ; set; }
  
  /// <summary>
  /// PivotArea.
  /// </summary>
  public PivotArea? PivotArea { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
