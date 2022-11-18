namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Hierarchy.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICacheHierarchyExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFieldsUsage))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGroupLevels))]
public interface ICacheHierarchy // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// uniqueName
  /// </summary>
  public string? UniqueName { get ; set; }
  
  /// <summary>
  /// caption
  /// </summary>
  public string? Caption { get ; set; }
  
  /// <summary>
  /// measure
  /// </summary>
  public bool? Measure { get ; set; }
  
  /// <summary>
  /// set
  /// </summary>
  public bool? Set { get ; set; }
  
  /// <summary>
  /// parentSet
  /// </summary>
  public uint? ParentSet { get ; set; }
  
  /// <summary>
  /// iconSet
  /// </summary>
  public int? IconSet { get ; set; }
  
  /// <summary>
  /// attribute
  /// </summary>
  public bool? Attribute { get ; set; }
  
  /// <summary>
  /// time
  /// </summary>
  public bool? Time { get ; set; }
  
  /// <summary>
  /// keyAttribute
  /// </summary>
  public bool? KeyAttribute { get ; set; }
  
  /// <summary>
  /// defaultMemberUniqueName
  /// </summary>
  public string? DefaultMemberUniqueName { get ; set; }
  
  /// <summary>
  /// allUniqueName
  /// </summary>
  public string? AllUniqueName { get ; set; }
  
  /// <summary>
  /// allCaption
  /// </summary>
  public string? AllCaption { get ; set; }
  
  /// <summary>
  /// dimensionUniqueName
  /// </summary>
  public string? DimensionUniqueName { get ; set; }
  
  /// <summary>
  /// displayFolder
  /// </summary>
  public string? DisplayFolder { get ; set; }
  
  /// <summary>
  /// measureGroup
  /// </summary>
  public string? MeasureGroup { get ; set; }
  
  /// <summary>
  /// measures
  /// </summary>
  public bool? Measures { get ; set; }
  
  /// <summary>
  /// count
  /// </summary>
  public uint? Count { get ; set; }
  
  /// <summary>
  /// oneField
  /// </summary>
  public bool? OneField { get ; set; }
  
  /// <summary>
  /// memberValueDatatype
  /// </summary>
  public ushort? MemberValueDatatype { get ; set; }
  
  /// <summary>
  /// unbalanced
  /// </summary>
  public bool? Unbalanced { get ; set; }
  
  /// <summary>
  /// unbalancedGroup
  /// </summary>
  public bool? UnbalancedGroup { get ; set; }
  
  /// <summary>
  /// hidden
  /// </summary>
  public bool? Hidden { get ; set; }
  
  /// <summary>
  /// FieldsUsage.
  /// </summary>
  public IFieldsUsage? FieldsUsage { get ; set; }
  
  /// <summary>
  /// GroupLevels.
  /// </summary>
  public IGroupLevels? GroupLevels { get ; set; }
  
  /// <summary>
  /// CacheHierarchyExtensionList.
  /// </summary>
  public ICacheHierarchyExtensionList? CacheHierarchyExtensionList { get ; set; }
  
}
