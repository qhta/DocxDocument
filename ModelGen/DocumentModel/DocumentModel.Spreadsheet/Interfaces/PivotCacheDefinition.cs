namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotCacheDefinition Class.
/// </summary>
public interface PivotCacheDefinition // : System.Boolean
{
  /// <summary>
  /// slicerData, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? SlicerData { get ; set; }
  
  /// <summary>
  /// pivotCacheId, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? PivotCacheId { get ; set; }
  
  /// <summary>
  /// supportSubqueryNonVisual, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? SupportSubqueryNonVisual { get ; set; }
  
  /// <summary>
  /// supportSubqueryCalcMem, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? SupportSubqueryCalcMem { get ; set; }
  
  /// <summary>
  /// supportAddCalcMems, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? SupportAddCalcMems { get ; set; }
  
}
