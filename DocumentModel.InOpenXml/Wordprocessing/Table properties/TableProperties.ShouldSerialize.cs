namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableProperties
{
  public bool ShouldSerializeTablePropertiesChange() => TablePropertiesChange is not null && ShouldSerialize(TablePropertiesChange);
}
