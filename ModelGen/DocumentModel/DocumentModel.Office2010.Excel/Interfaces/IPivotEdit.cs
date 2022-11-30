namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotEdit Class.
/// </summary>
public interface IPivotEdit // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PivotUserEdit.
  /// </summary>
  public DocumentModel.Office2010.Excel.IPivotUserEdit? PivotUserEdit { get ; set; }
  
  /// <summary>
  /// TupleItems.
  /// </summary>
  public DocumentModel.Office2010.Excel.ITupleItems? TupleItems { get ; set; }
  
  /// <summary>
  /// PivotArea.
  /// </summary>
  public DocumentModel.Office2010.Excel.IPivotArea? PivotArea { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
