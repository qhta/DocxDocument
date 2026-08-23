namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single data source record for mail merge in a WordprocessingML document.
/// This class extends <see cref = "CollectionItem"/> and provides properties for record inclusion and a unique hash code, enabling advanced configuration and management of individual recipient records in mail merge operations.
/// </summary>
[OpenXmlType(typeof(DXOW.SingleDataSourceRecord))]
[DataContract]
[XmlRoot("SingleDataSourceRecord", Namespace = "DocumentModel.Wordprocessing")]
public partial class SingleDataSourceRecord: ModelElement<DXOW.SingleDataSourceRecord>
{
  /// <summary>
  /// Indicates whether the record is included in the mail merge.
  /// </summary>
  [OpenXmlProperty(nameof(DXOW.SingleDataSourceRecord.RecordIncluded))]
  public bool? RecordIncluded
  {
    get => _RecordIncluded ??= GetProperty<bool?>(GetUpdatableElement()?.RecordIncluded);
    set => UpdateField(ref _RecordIncluded, value, nameof(RecordIncluded));
  }

  private bool? _RecordIncluded;

  /// <summary>
  /// Unique hash code for the record, used to identify and track the record in the data source.
  /// </summary>
  [OpenXmlProperty(nameof(DXOW.SingleDataSourceRecord.RecordHashCode))]
  public Int64? RecordHashCode
  {
    get => _RecordHashCode ??= GetProperty<Int64?>(GetUpdatableElement()?.RecordHashCode);
    set => UpdateField(ref _RecordHashCode, value, nameof(RecordHashCode));
  }

  private Int64? _RecordHashCode;
}