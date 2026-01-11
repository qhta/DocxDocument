namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the mapping between an external data source column and a merge field in a WordprocessingML mail merge operation.
/// This interface extends <see cref="CollectionItem"/> and provides properties for field type, data source column name, mapped merge field name, column index, language ID, and dynamic address ordering, enabling advanced configuration of mail merge field mappings.
/// </summary>
public interface FieldMapData : CollectionItem
{
  /// <summary>
  /// Type of merge field mapping, specifying how the data source column is mapped to the merge field.
  /// </summary>
  public MailMergeOdsoFieldKind? MailMergeFieldType { get; set; }

  /// <summary>
  /// Name of the data source column being mapped.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// Predefined merge field name to which the data source column is mapped.
  /// </summary>
  public string? MappedName { get; set; }

  /// <summary>
  /// Index of the data source column being mapped, specified as a zero-based index.
  /// </summary>
  public UInt32? ColumnIndex { get; set; }

  /// <summary>
  /// Language ID for the merge field name, specifying the language context for the mapping.
  /// </summary>
  public string? LanguageId { get; set; }

  /// <summary>
  /// Indicates whether country/region-based address field ordering is used for the mapping.
  /// </summary>
  public bool? DynamicAddress { get; set; }
}