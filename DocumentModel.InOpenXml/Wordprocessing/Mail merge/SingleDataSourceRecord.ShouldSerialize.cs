namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class SingleDataSourceRecord
{
  public bool ShouldSerializeRecordIncluded() => RecordIncluded is not null;
  public bool ShouldSerializeRecordHashCode() => RecordHashCode is not null;
}
