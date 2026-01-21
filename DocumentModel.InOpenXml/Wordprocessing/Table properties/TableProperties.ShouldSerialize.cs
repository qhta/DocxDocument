namespace DocumentModel.Wordprocessing;

public partial class TableProperties
{
  public bool ShouldSerializeTablePropertiesChange() => TablePropertiesChange is not null;
}
