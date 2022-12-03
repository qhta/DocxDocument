namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotChange Class.
/// </summary>
public interface PivotChange // : DocumentModel.BaseTypes.ModelElement
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
  public PivotEditValue? PivotEditValue { get ; set; }
  
  /// <summary>
  /// TupleItems.
  /// </summary>
  public TupleItems? TupleItems { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
