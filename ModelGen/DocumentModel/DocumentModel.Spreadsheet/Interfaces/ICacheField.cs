namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Field.
/// </summary>
public interface ICacheField // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// caption
  /// </summary>
  public System.String? Caption { get ; set; }
  
  /// <summary>
  /// propertyName
  /// </summary>
  public System.String? PropertyName { get ; set; }
  
  /// <summary>
  /// serverField
  /// </summary>
  public System.Boolean? ServerField { get ; set; }
  
  /// <summary>
  /// uniqueList
  /// </summary>
  public System.Boolean? UniqueList { get ; set; }
  
  /// <summary>
  /// numFmtId
  /// </summary>
  public System.UInt32? NumberFormatId { get ; set; }
  
  /// <summary>
  /// formula
  /// </summary>
  public System.String? Formula { get ; set; }
  
  /// <summary>
  /// sqlType
  /// </summary>
  public System.Int32? SqlType { get ; set; }
  
  /// <summary>
  /// hierarchy
  /// </summary>
  public System.Int32? Hierarchy { get ; set; }
  
  /// <summary>
  /// level
  /// </summary>
  public System.UInt32? Level { get ; set; }
  
  /// <summary>
  /// databaseField
  /// </summary>
  public System.Boolean? DatabaseField { get ; set; }
  
  /// <summary>
  /// mappingCount
  /// </summary>
  public System.UInt32? MappingCount { get ; set; }
  
  /// <summary>
  /// memberPropertyField
  /// </summary>
  public System.Boolean? MemberPropertyField { get ; set; }
  
  /// <summary>
  /// SharedItems.
  /// </summary>
  public DocumentModel.Spreadsheet.ISharedItems? SharedItems { get ; set; }
  
  /// <summary>
  /// FieldGroup.
  /// </summary>
  public DocumentModel.Spreadsheet.IFieldGroup? FieldGroup { get ; set; }
  
}
