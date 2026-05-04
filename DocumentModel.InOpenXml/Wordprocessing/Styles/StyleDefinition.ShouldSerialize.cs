namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class StyleDefinition
{
  public bool ShouldSerializeType() => Type is not null && ShouldSerialize(Type);
  public bool ShouldSerializeStyleId() => !String.IsNullOrEmpty(StyleId);
  public bool ShouldSerializeStyleName() => !String.IsNullOrEmpty(StyleName);
  public bool ShouldSerializeIsDefault() => IsDefault is not null;
  public bool ShouldSerializeIsCustom() => IsCustom is not null;
  public bool ShouldSerializeBasedOn() => !String.IsNullOrEmpty(BasedOn);
  public bool ShouldSerializeNextParagraphStyle() => !String.IsNullOrEmpty(NextParagraphStyle);
  public bool ShouldSerializeLinkedStyle() => !String.IsNullOrEmpty(LinkedStyle);
  public bool ShouldSerializeIsAutoRedefined() => IsAutoRedefined is not null && ShouldSerialize(IsAutoRedefined);
  public bool ShouldSerializeIsHidden() => IsHidden is not null && ShouldSerialize(IsHidden);
  public bool ShouldSerializeUIPriority() => UIPriority is not null && ShouldSerialize(UIPriority);
  public bool ShouldSerializeRsid() => Rsid is not null && ShouldSerialize(Rsid);
}
