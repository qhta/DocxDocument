namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CalculatedMember Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ITupleSet))]
public interface ICalculatedMember // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// displayFolder, this property is only available in Office 2010 and later.
  /// </summary>
  public string? DisplayFolder { get ; set; }
  
  /// <summary>
  /// flattenHierarchies, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FlattenHierarchies { get ; set; }
  
  /// <summary>
  /// dynamicSet, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? DynamicSet { get ; set; }
  
  /// <summary>
  /// hierarchizeDistinct, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? HierarchizeDistinct { get ; set; }
  
  /// <summary>
  /// mdxLong, this property is only available in Office 2010 and later.
  /// </summary>
  public string? MdxLong { get ; set; }
  
  /// <summary>
  /// TupleSet.
  /// </summary>
  public DocumentModel.Office2010.Excel.ITupleSet? TupleSet { get ; set; }
  
}
