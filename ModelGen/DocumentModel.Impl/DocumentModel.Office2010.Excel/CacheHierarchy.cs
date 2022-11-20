namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CacheHierarchy Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISetLevels))]
public class CacheHierarchy: ICacheHierarchy
{
  /// <summary>
  /// flattenHierarchies, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FlattenHierarchies
  {
    get;
    set;
  }
  
  /// <summary>
  /// measuresSet, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? MeasuresSet
  {
    get;
    set;
  }
  
  /// <summary>
  /// hierarchizeDistinct, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? HierarchizeDistinct
  {
    get;
    set;
  }
  
  /// <summary>
  /// ignore, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Ignore
  {
    get;
    set;
  }
  
  /// <summary>
  /// SetLevels.
  /// </summary>
  public ISetLevels? SetLevels
  {
    get;
    set;
  }
  
}
