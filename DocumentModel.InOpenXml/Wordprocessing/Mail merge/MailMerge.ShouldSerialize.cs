namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class MailMerge
{
  public bool ShouldSerializeMainDocumentType() => MainDocumentType is not null;
  public bool ShouldSerializeLinkToQuery() => LinkToQuery is not null;
  public bool ShouldSerializeDataType() => DataType is not null;
  public bool ShouldSerializeConnectString() => ConnectString is not null;
  public bool ShouldSerializeQuery() => Query is not null;
  public bool ShouldSerializeDataSourceReference() => DataSourceReference is not null;
  public bool ShouldSerializeHeaderSource() => HeaderSource is not null;
  public bool ShouldSerializeDoNotSuppressBlankLines() => DoNotSuppressBlankLines is not null;
  public bool ShouldSerializeDestination() => Destination is not null;
  public bool ShouldSerializeAddressFieldName() => AddressFieldName is not null;
  public bool ShouldSerializeMailSubject() => MailSubject is not null;
  public bool ShouldSerializeMailAsAttachment() => MailAsAttachment is not null;
  public bool ShouldSerializeViewMergedData() => ViewMergedData is not null;
  public bool ShouldSerializeActiveRecord() => ActiveRecord is not null;
  public bool ShouldSerializeCheckErrors() => CheckErrors is not null;
  public bool ShouldSerializeDataSourceObject() => DataSourceObject is not null;
}
