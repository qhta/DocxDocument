namespace DocumentModel.Wordprocessing;

/// <summary>
///   External Data Source to Merge Field Mapping.
/// </summary>
public class FieldMapData: ModelElement
{
  /// <summary>
  ///   Merge Field Mapping.
  /// </summary>
  public MailMergeOdsoFieldKind? MailMergeFieldType { get; set; }

  /// <summary>
  ///   Data Source Name for Column.
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   Predefined Merge Field Name.
  /// </summary>
  public String? MappedName { get; set; }

  /// <summary>
  ///   Index of Column Being Mapped.
  /// </summary>
  public UInt32? ColumnIndex { get; set; }

  /// <summary>
  ///   Merge Field Name Language ID.
  /// </summary>
  public String? LanguageId { get; set; }

  /// <summary>
  ///   Use Country/Region-Based Address Field Ordering.
  /// </summary>
  public Boolean? DynamicAddress { get; set; }
}