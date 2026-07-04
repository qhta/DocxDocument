namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DataSourceObject
{
  public bool ShouldSerializeUdlConnectionString() => !String.IsNullOrEmpty(UdlConnectionString);
  public bool ShouldSerializeDataSourceTableName() => !String.IsNullOrEmpty(DataSourceTableName);
  public bool ShouldSerializeSourceReference() => SourceReference is not null && ShouldSerialize(SourceReference);
  public bool ShouldSerializeColumnDelimiter() => ColumnDelimiter is not null && ShouldSerialize(ColumnDelimiter);
  public bool ShouldSerializeMailMergeSource() => MailMergeSource is not null && ShouldSerialize(MailMergeSource);
  public bool ShouldSerializeFirstRowHeader() => FirstRowHeader is not null;
  public bool ShouldSerializeFieldMap() => FieldMap is not null && ShouldSerialize(FieldMap);
  public bool ShouldSerializeRecipientDataReferences() => RecipientDataReference is not null && ShouldSerialize(RecipientDataReference);
}
