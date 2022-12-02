namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotChange Class.
/// </summary>
public interface IPivotChange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// allocationMethod, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.AllocationMethodKind? AllocationMethod { get ; set; }
  
  /// <summary>
  /// weightExpression, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? WeightExpression { get ; set; }
  
  /// <summary>
  /// PivotEditValue.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotEditValue? PivotEditValue { get ; set; }
  
  /// <summary>
  /// TupleItems.
  /// </summary>
  public DocumentModel.Spreadsheet.ITupleItems? TupleItems { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
