namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CalculatedMember Class.
/// </summary>
public interface ICalculatedMember // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// displayFolder, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? DisplayFolder { get ; set; }
  
  /// <summary>
  /// flattenHierarchies, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FlattenHierarchies { get ; set; }
  
  /// <summary>
  /// dynamicSet, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? DynamicSet { get ; set; }
  
  /// <summary>
  /// hierarchizeDistinct, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? HierarchizeDistinct { get ; set; }
  
  /// <summary>
  /// mdxLong, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? MdxLong { get ; set; }
  
  /// <summary>
  /// TupleSet.
  /// </summary>
  public DocumentModel.Office2010.Excel.ITupleSet? TupleSet { get ; set; }
  
}
