namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Field.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICacheFieldExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFieldGroup))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISharedItems))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMemberPropertiesMap))]
public interface ICacheField // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// caption
  /// </summary>
  public string? Caption { get ; set; }
  
  /// <summary>
  /// propertyName
  /// </summary>
  public string? PropertyName { get ; set; }
  
  /// <summary>
  /// serverField
  /// </summary>
  public bool? ServerField { get ; set; }
  
  /// <summary>
  /// uniqueList
  /// </summary>
  public bool? UniqueList { get ; set; }
  
  /// <summary>
  /// numFmtId
  /// </summary>
  public uint? NumberFormatId { get ; set; }
  
  /// <summary>
  /// formula
  /// </summary>
  public string? Formula { get ; set; }
  
  /// <summary>
  /// sqlType
  /// </summary>
  public int? SqlType { get ; set; }
  
  /// <summary>
  /// hierarchy
  /// </summary>
  public int? Hierarchy { get ; set; }
  
  /// <summary>
  /// level
  /// </summary>
  public uint? Level { get ; set; }
  
  /// <summary>
  /// databaseField
  /// </summary>
  public bool? DatabaseField { get ; set; }
  
  /// <summary>
  /// mappingCount
  /// </summary>
  public uint? MappingCount { get ; set; }
  
  /// <summary>
  /// memberPropertyField
  /// </summary>
  public bool? MemberPropertyField { get ; set; }
  
  /// <summary>
  /// SharedItems.
  /// </summary>
  public ISharedItems? SharedItems { get ; set; }
  
  /// <summary>
  /// FieldGroup.
  /// </summary>
  public IFieldGroup? FieldGroup { get ; set; }
  
}
