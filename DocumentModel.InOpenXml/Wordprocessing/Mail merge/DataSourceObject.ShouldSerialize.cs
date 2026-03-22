namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class DataSourceObject
{
  public bool ShouldSerializeUdlConnectionString() => UdlConnectionString is not null;
  public bool ShouldSerializeDataSourceTableName() => DataSourceTableName is not null;
  public bool ShouldSerializeSourceReference() => SourceReference is not null;
  public bool ShouldSerializeColumnDelimiter() => ColumnDelimiter is not null;
  public bool ShouldSerializeMailMergeSource() => MailMergeSource is not null;
  public bool ShouldSerializeFirstRowHeader() => FirstRowHeader is not null;
  public bool ShouldSerializeFieldMap() => FieldMap is not null;
  public bool ShouldSerializeRecipientDataReference() => RecipientDataReference is not null;
}
