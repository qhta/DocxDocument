namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CacheHierarchy Class.
/// </summary>
public interface ICacheHierarchy // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// flattenHierarchies, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FlattenHierarchies { get ; set; }
  
  /// <summary>
  /// measuresSet, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? MeasuresSet { get ; set; }
  
  /// <summary>
  /// hierarchizeDistinct, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? HierarchizeDistinct { get ; set; }
  
  /// <summary>
  /// ignore, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Ignore { get ; set; }
  
  /// <summary>
  /// SetLevels.
  /// </summary>
  public DocumentModel.Office2010.Excel.ISetLevels? SetLevels { get ; set; }
  
}
