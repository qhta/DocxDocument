namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class AbstractNumbering
{
  public bool ShouldSerializeAbstractNumId() => AbstractNumId is not null;
  public bool ShouldSerializeNsId() => NsId is not null;
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeMultiLevelType() => MultiLevelType is not null;
  public bool ShouldSerializeTemplateCode() => TemplateCode is not null;
  public bool ShouldSerializeStyleLink() => !String.IsNullOrEmpty(StyleLink);
  public bool ShouldSerializeNumberingStyleLink() => !String.IsNullOrEmpty(NumberingStyleLink);
}
