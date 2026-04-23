namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FieldMapData
{
  public bool ShouldSerializeMailMergeFieldType() => MailMergeFieldType is not null && ShouldSerialize(MailMergeFieldType);
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeMappedName() => !String.IsNullOrEmpty(MappedName);
  public bool ShouldSerializeColumnIndex() => ColumnIndex is not null && ShouldSerialize(ColumnIndex);
  public bool ShouldSerializeLanguageId() => !String.IsNullOrEmpty(LanguageId);
  public bool ShouldSerializeDynamicAddress() => DynamicAddress is not null;
}
