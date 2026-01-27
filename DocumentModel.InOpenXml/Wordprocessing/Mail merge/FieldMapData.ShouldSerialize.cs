namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FieldMapData
{
  public bool ShouldSerializeMailMergeFieldType() => MailMergeFieldType is not null;
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeMappedName() => MappedName is not null;
  public bool ShouldSerializeColumnIndex() => ColumnIndex is not null;
  public bool ShouldSerializeLanguageId() => LanguageId is not null;
  public bool ShouldSerializeDynamicAddress() => DynamicAddress is not null;
}
