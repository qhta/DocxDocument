namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotChange Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotEditValue))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ITupleItems))]
public interface IPivotChange // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// allocationMethod, this property is only available in Office 2010 and later.
  /// </summary>
  public AllocationMethod? AllocationMethod { get ; set; }
  
  /// <summary>
  /// weightExpression, this property is only available in Office 2010 and later.
  /// </summary>
  public string? WeightExpression { get ; set; }
  
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
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
