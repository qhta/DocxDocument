namespace DocumentModel.Wordprocessing;


/// <summary>
///   External Data Source to Merge Field Mapping.
/// </summary>
public partial class FieldMapData
{
  
  /// <summary>
  ///   Merge Field Mapping.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeOdsoFieldKind? MailMergeFieldType { get; set; }
  
  
  /// <summary>
  ///   Data Source Name for Column.
  /// </summary>
  public DocumentModel.Wordprocessing.Name? Name { get; set; }
  
  
  /// <summary>
  ///   Predefined Merge Field Name.
  /// </summary>
  public DocumentModel.Wordprocessing.MappedName? MappedName { get; set; }
  
  
  /// <summary>
  ///   Index of Column Being Mapped.
  /// </summary>
  public DocumentModel.Wordprocessing.ColumnIndex? ColumnIndex { get; set; }
  
  
  /// <summary>
  ///   Merge Field Name Language ID.
  /// </summary>
  public String? LanguageId { get; set; }
  
  
  /// <summary>
  ///   Use Country/Region-Based Address Field Ordering.
  /// </summary>
  public DocumentModel.Wordprocessing.DynamicAddress? DynamicAddress { get; set; }
  
}
