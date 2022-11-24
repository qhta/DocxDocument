namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Data Source to Merge Field Mapping.
/// </summary>
public interface IFieldMapData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Merge Field Mapping.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues>? MailMergeFieldType { get ; set; }
  
  /// <summary>
  /// Data Source Name for Column.
  /// </summary>
  public IName? Name { get ; set; }
  
  /// <summary>
  /// Predefined Merge Field Name.
  /// </summary>
  public IMappedName? MappedName { get ; set; }
  
  /// <summary>
  /// Index of Column Being Mapped.
  /// </summary>
  public IColumnIndex? ColumnIndex { get ; set; }
  
  /// <summary>
  /// Merge Field Name Language ID.
  /// </summary>
  public IStringValue? LanguageId { get ; set; }
  
  /// <summary>
  /// Use Country/Region-Based Address Field Ordering.
  /// </summary>
  public IDynamicAddress? DynamicAddress { get ; set; }
  
}
