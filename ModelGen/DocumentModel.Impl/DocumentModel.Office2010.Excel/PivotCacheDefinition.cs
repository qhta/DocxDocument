namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotCacheDefinition Class.
/// </summary>
public class PivotCacheDefinition: IPivotCacheDefinition
{
  /// <summary>
  /// slicerData, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? SlicerData
  {
    get;
    set;
  }
  
  /// <summary>
  /// pivotCacheId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? PivotCacheId
  {
    get;
    set;
  }
  
  /// <summary>
  /// supportSubqueryNonVisual, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? SupportSubqueryNonVisual
  {
    get;
    set;
  }
  
  /// <summary>
  /// supportSubqueryCalcMem, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? SupportSubqueryCalcMem
  {
    get;
    set;
  }
  
  /// <summary>
  /// supportAddCalcMems, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? SupportAddCalcMems
  {
    get;
    set;
  }
  
}
