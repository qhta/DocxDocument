namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class AbstractNumbering
{
  public bool ShouldSerializeAbstractNumId() => AbstractNumId is not null;
  public bool ShouldSerializeNsId() => NsId is not null;
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeMultiLevelType() => MultiLevelType is not null;
  public bool ShouldSerializeTemplateCode() => TemplateCode is not null;
  public bool ShouldSerializeStyleLink() => StyleLink is not null;
  public bool ShouldSerializeNumberingStyleLink() => NumberingStyleLink is not null;
  public bool ShouldSerializeLevels() => Levels is not null;
}
