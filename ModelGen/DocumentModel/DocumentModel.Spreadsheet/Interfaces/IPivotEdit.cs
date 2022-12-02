namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotEdit Class.
/// </summary>
public interface IPivotEdit // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PivotUserEdit.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotUserEdit? PivotUserEdit { get ; set; }
  
  /// <summary>
  /// TupleItems.
  /// </summary>
  public DocumentModel.Spreadsheet.ITupleItems? TupleItems { get ; set; }
  
  /// <summary>
  /// PivotArea.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotArea? PivotArea { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
