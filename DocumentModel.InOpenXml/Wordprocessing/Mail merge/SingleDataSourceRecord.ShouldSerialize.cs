namespace DocumentModel.Wordprocessing;

public partial class SingleDataSourceRecord
{
  public bool ShouldSerializeRecordIncluded() => RecordIncluded is not null;
  public bool ShouldSerializeRecordHashCode() => RecordHashCode is not null;
}
