namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotChange Class.
/// </summary>
public interface IPivotChange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// allocationMethod, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.AllocationMethodKind? AllocationMethod { get ; set; }
  
  /// <summary>
  /// weightExpression, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? WeightExpression { get ; set; }
  
  /// <summary>
  /// PivotEditValue.
  /// </summary>
  public DocumentModel.Office2010.Excel.IPivotEditValue? PivotEditValue { get ; set; }
  
  /// <summary>
  /// TupleItems.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? TupleItems { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
