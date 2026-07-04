namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the mapping between an external data source column and a merge field in a WordprocessingML mail merge operation.
/// This class extends <see cref = "CollectionItem"/> and provides properties for field type, data source column name, mapped merge field name, column index, language ID, and dynamic address ordering, enabling advanced configuration of mail merge field mappings.
/// </summary>
[OpenXmlType(typeof(DXW.FieldMapData))]
[DataContract]
[XmlRoot("FieldMapData", Namespace = "DocumentModel.Wordprocessing")]
public partial class FieldMapData : ModelElement<DXW.FieldMapData>
{
  /// <summary>
  /// Type of merge field mapping, specifying how the data source column is mapped to the merge field.
  /// </summary>
  [OpenXmlElement(typeof(DXW.MailMergeFieldType), Order = 1)]
  public MailMergeOdsoField? MailMergeFieldType { get => _MailMergeFieldType; set => UpdateField(ref _MailMergeFieldType, value, nameof(MailMergeFieldType)); }
  private MailMergeOdsoField? _MailMergeFieldType;

  /// <summary>
  /// Name of the data source column being mapped.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Name), Order = 2)]
  public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
  private string? _Name;

  /// <summary>
  /// Predefined merge field name to which the data source column is mapped.
  /// </summary>
  [OpenXmlElement(typeof(DXW.MappedName), Order = 3)]
  public string? MappedName { get => _MappedName; set => UpdateField(ref _MappedName, value, nameof(MappedName)); }
  private string? _MappedName;

  /// <summary>
  /// Index of the data source column being mapped, specified as a zero-based index.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ColumnIndex), Order = 4)]
  public UInt16? ColumnIndex { get => _ColumnIndex; set => UpdateField(ref _ColumnIndex, value, nameof(ColumnIndex)); }
  private UInt16? _ColumnIndex;

  /// <summary>
  /// Language ID for the merge field name, specifying the language context for the mapping.
  /// </summary>
  [OpenXmlElement(typeof(DXW.LanguageId), Order = 5)]
  public string? LanguageId { get => _LanguageId; set => UpdateField(ref _LanguageId, value, nameof(LanguageId)); }
  private string? _LanguageId;

  /// <summary>
  /// Indicates whether country/region-based address field ordering is used for the mapping.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DynamicAddress), Order = 6)]
  public bool? DynamicAddress { get => _DynamicAddress; set => UpdateField(ref _DynamicAddress, value, nameof(DynamicAddress)); }
  private bool? _DynamicAddress;
}