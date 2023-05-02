namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  public string? Name { get; set; }

  /// <summary>
  ///   Predefined Merge Field Name.
  /// </summary>
  public string? MappedName { get; set; }

  /// <summary>
  ///   Index of Column Being Mapped.
  /// </summary>
  public UInt32? ColumnIndex { get; set; }

  /// <summary>
  ///   Merge Field Name Language ID.
  /// </summary>
  public string? LanguageId { get; set; }

  /// <summary>
  ///   Use Country/Region-Based Address Field Ordering.
  /// </summary>
  public bool? DynamicAddress { get; set; }
}