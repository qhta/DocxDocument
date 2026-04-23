namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class MailMerge
{
  public bool ShouldSerializeMainDocumentType() => MainDocumentType is not null && ShouldSerialize(MainDocumentType);
  public bool ShouldSerializeLinkToQuery() => LinkToQuery is not null;
  public bool ShouldSerializeDataType() => DataType is not null && ShouldSerialize(DataType);
  public bool ShouldSerializeConnectString() => !String.IsNullOrEmpty(ConnectString);
  public bool ShouldSerializeQuery() => !String.IsNullOrEmpty(Query);
  public bool ShouldSerializeDataSourceReference() => DataSourceReference is not null && ShouldSerialize(DataSourceReference);
  public bool ShouldSerializeHeaderSource() => HeaderSource is not null && ShouldSerialize(HeaderSource);
  public bool ShouldSerializeDoNotSuppressBlankLines() => DoNotSuppressBlankLines is not null;
  public bool ShouldSerializeDestination() => Destination is not null && ShouldSerialize(Destination);
  public bool ShouldSerializeAddressFieldName() => !String.IsNullOrEmpty(AddressFieldName);
  public bool ShouldSerializeMailSubject() => !String.IsNullOrEmpty(MailSubject);
  public bool ShouldSerializeMailAsAttachment() => MailAsAttachment is not null;
  public bool ShouldSerializeViewMergedData() => ViewMergedData is not null;
  public bool ShouldSerializeActiveRecord() => ActiveRecord is not null && ShouldSerialize(ActiveRecord);
  public bool ShouldSerializeCheckErrors() => CheckErrors is not null && ShouldSerialize(CheckErrors);
  public bool ShouldSerializeDataSourceObject() => DataSourceObject is not null && ShouldSerialize(DataSourceObject);
}
