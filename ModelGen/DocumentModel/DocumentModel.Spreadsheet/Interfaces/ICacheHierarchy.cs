namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Hierarchy.
/// </summary>
public interface ICacheHierarchy // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// uniqueName
  /// </summary>
  public System.String? UniqueName { get ; set; }
  
  /// <summary>
  /// caption
  /// </summary>
  public System.String? Caption { get ; set; }
  
  /// <summary>
  /// measure
  /// </summary>
  public System.Boolean? Measure { get ; set; }
  
  /// <summary>
  /// set
  /// </summary>
  public System.Boolean? Set { get ; set; }
  
  /// <summary>
  /// parentSet
  /// </summary>
  public System.UInt32? ParentSet { get ; set; }
  
  /// <summary>
  /// iconSet
  /// </summary>
  public System.Int32? IconSet { get ; set; }
  
  /// <summary>
  /// attribute
  /// </summary>
  public System.Boolean? Attribute { get ; set; }
  
  /// <summary>
  /// time
  /// </summary>
  public System.Boolean? Time { get ; set; }
  
  /// <summary>
  /// keyAttribute
  /// </summary>
  public System.Boolean? KeyAttribute { get ; set; }
  
  /// <summary>
  /// defaultMemberUniqueName
  /// </summary>
  public System.String? DefaultMemberUniqueName { get ; set; }
  
  /// <summary>
  /// allUniqueName
  /// </summary>
  public System.String? AllUniqueName { get ; set; }
  
  /// <summary>
  /// allCaption
  /// </summary>
  public System.String? AllCaption { get ; set; }
  
  /// <summary>
  /// dimensionUniqueName
  /// </summary>
  public System.String? DimensionUniqueName { get ; set; }
  
  /// <summary>
  /// displayFolder
  /// </summary>
  public System.String? DisplayFolder { get ; set; }
  
  /// <summary>
  /// measureGroup
  /// </summary>
  public System.String? MeasureGroup { get ; set; }
  
  /// <summary>
  /// measures
  /// </summary>
  public System.Boolean? Measures { get ; set; }
  
  /// <summary>
  /// count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  /// <summary>
  /// oneField
  /// </summary>
  public System.Boolean? OneField { get ; set; }
  
  /// <summary>
  /// memberValueDatatype
  /// </summary>
  public System.UInt16? MemberValueDatatype { get ; set; }
  
  /// <summary>
  /// unbalanced
  /// </summary>
  public System.Boolean? Unbalanced { get ; set; }
  
  /// <summary>
  /// unbalancedGroup
  /// </summary>
  public System.Boolean? UnbalancedGroup { get ; set; }
  
  /// <summary>
  /// hidden
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// FieldsUsage.
  /// </summary>
  public DocumentModel.Spreadsheet.IFieldsUsage? FieldsUsage { get ; set; }
  
  /// <summary>
  /// GroupLevels.
  /// </summary>
  public DocumentModel.Spreadsheet.IGroupLevels? GroupLevels { get ; set; }
  
  /// <summary>
  /// CacheHierarchyExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.ICacheHierarchyExtensionList? CacheHierarchyExtensionList { get ; set; }
  
}
