namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class StyleDef
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeStyleId() => StyleId is not null;
  public bool ShouldSerializeStyleName() => StyleName is not null;
  public bool ShouldSerializeIsDefault() => IsDefault is not null;
  public bool ShouldSerializeIsCustom() => IsCustom is not null;
  public bool ShouldSerializeBasedOn() => BasedOn is not null;
  public bool ShouldSerializeNextParagraphStyle() => NextParagraphStyle is not null;
  public bool ShouldSerializeLinkedStyle() => LinkedStyle is not null;
  public bool ShouldSerializeIsAutoRedefined() => IsAutoRedefined;
  public bool ShouldSerializeIsHidden() => IsHidden != 0;
  public bool ShouldSerializeUIPriority() => UIPriority is not null;
  public bool ShouldSerializeIsPrimary() => IsPrimary;
  public bool ShouldSerializeIsLocked() => IsLocked;
  public bool ShouldSerializeIsPersonal() => IsPersonal;
  public bool ShouldSerializeIsPersonalCompose() => IsPersonalCompose;
  public bool ShouldSerializeIsPersonalReply() => IsPersonalReply;
  public bool ShouldSerializeRsid() => Rsid is not null;
  //public bool ShouldSerializeStyleParagraphProperties() => StyleParagraphProperties is not null;
  //public bool ShouldSerializeStyleRunProperties() => StyleRunProperties is not null;
  //public bool ShouldSerializeStyleTableProperties() => StyleTableProperties is not null;
  //public bool ShouldSerializeTableStyleConditionalFormattingTableRowProperties() => TableStyleConditionalFormattingTableRowProperties is not null;
  //public bool ShouldSerializeStyleTableCellProperties() => StyleTableCellProperties is not null;
  //public bool ShouldSerializeTableStyleConditionalProperties() => TableStyleConditionalProperties is not null;
}
