namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Data Source to Merge Field Mapping.
/// </summary>
public interface IFieldMapData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Merge Field Mapping.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeOdsoFieldKind? MailMergeFieldType { get ; set; }
  
  /// <summary>
  /// Data Source Name for Column.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Predefined Merge Field Name.
  /// </summary>
  public System.String? MappedName { get ; set; }
  
  /// <summary>
  /// Index of Column Being Mapped.
  /// </summary>
  public System.UInt32? ColumnIndex { get ; set; }
  
  /// <summary>
  /// Merge Field Name Language ID.
  /// </summary>
  public System.String? LanguageId { get ; set; }
  
  /// <summary>
  /// Use Country/Region-Based Address Field Ordering.
  /// </summary>
  public System.Boolean? DynamicAddress { get ; set; }
  
}
