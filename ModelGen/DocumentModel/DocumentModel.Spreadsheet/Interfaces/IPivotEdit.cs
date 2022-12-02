namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotEdit Class.
/// </summary>
public interface IPivotEdit // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PivotUserEdit.
  /// </summary>
  public IPivotUserEdit? PivotUserEdit { get ; set; }
  
  /// <summary>
  /// TupleItems.
  /// </summary>
  public ITupleItems? TupleItems { get ; set; }
  
  /// <summary>
  /// PivotArea.
  /// </summary>
  public IPivotArea? PivotArea { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
