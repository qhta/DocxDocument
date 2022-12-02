namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotChange Class.
/// </summary>
public interface IPivotChange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// allocationMethod, this property is only available in Office 2010 and later.
  /// </summary>
  public AllocationMethodKind? AllocationMethod { get ; set; }
  
  /// <summary>
  /// weightExpression, this property is only available in Office 2010 and later.
  /// </summary>
  public String? WeightExpression { get ; set; }
  
  /// <summary>
  /// PivotEditValue.
  /// </summary>
  public IPivotEditValue? PivotEditValue { get ; set; }
  
  /// <summary>
  /// TupleItems.
  /// </summary>
  public ITupleItems? TupleItems { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
