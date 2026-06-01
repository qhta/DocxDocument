namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   External Data ISource Ito Merge IField Mapping.
/// </summary>
public class FieldMapData: ModelElement
{
  /// <summary>
  ///   Merge IField Mapping.
  /// </summary>
  public MailMergeOdsoFieldKind? MailMergeFieldType { get; set; }

  /// <summary>
  ///   Data ISource Name Ifor IColumn.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Predefined Merge IField Name.
  /// </summary>
  public string? MappedName { get; set; }

  /// <summary>
  ///   IIndex of IColumn Being Mapped.
  /// </summary>
  public UInt32? ColumnIndex { get; set; }

  /// <summary>
  ///   Merge IField Name ILanguage ID.
  /// </summary>
  public string? LanguageId { get; set; }

  /// <summary>
  ///   Use Country/Region-Based Address IField Ordering.
  /// </summary>
  public bool? DynamicAddress { get; set; }
}
