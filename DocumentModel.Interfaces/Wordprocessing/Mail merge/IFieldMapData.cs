namespace DocumentModel.Wordprocessing;

/// <summary>
///   External Data Source to Merge Field Mapping.
/// </summary>
public interface IFieldMapData: IModelElement, ICollectionItem
{
  /// <summary>
  ///   Merge Field Mapping.
  /// </summary>
  public MailMergeOdsoFieldKind? MailMergeFieldType { get; set; }
  /// <summary>
  ///   Data Source Name for IColumn.
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Predefined Merge Field Name.
  /// </summary>
  public string? MappedName { get; set; }
  /// <summary>
  ///   Index of IColumn Being Mapped.
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