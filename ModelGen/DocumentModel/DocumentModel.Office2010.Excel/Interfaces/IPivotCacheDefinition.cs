namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotCacheDefinition Class.
/// </summary>
public interface IPivotCacheDefinition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// slicerData, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? SlicerData { get ; set; }
  
  /// <summary>
  /// pivotCacheId, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? PivotCacheId { get ; set; }
  
  /// <summary>
  /// supportSubqueryNonVisual, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? SupportSubqueryNonVisual { get ; set; }
  
  /// <summary>
  /// supportSubqueryCalcMem, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? SupportSubqueryCalcMem { get ; set; }
  
  /// <summary>
  /// supportAddCalcMems, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? SupportAddCalcMems { get ; set; }
  
}
